using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GasModelWin.Helper;
using GasModelWin.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZedGraph;
using Font = iTextSharp.text.Font;

namespace GasModelWin.Forms
{
    public partial class WorkHistoryForm : Form
    {
        ZedGraphControl zedGraph = new ZedGraphControl();

        public WorkHistoryForm()
        {
            InitializeComponent();
            pnlChart.Controls.Add(zedGraph);
            zedGraph.Dock = DockStyle.Fill;
            FillFilters();
            LoadData();
        }

        private void FillFilters()
        {
            cmbFormula.DataSource = new object[] {"", "Интегральная", "Дифференциальная"};
            using (var db = new GasContext())
            {
                var gases = db.Gases.ToList();
                gases.Insert(0, new Gas {Id = -1, Name = ""});
                cmbGasType.DataSource = gases;
                var users = db.Users.ToList();
                users.Insert(0, new User {Id = -1, Name = ""});
                cmbUser.DataSource = users;
            }            
        }

        private void LoadData(DateTime? date = null, User user = null, Gas gas = null,
            string modelingType = null, decimal? p1 = null, decimal? p2 = null)
        {
            using (var db = new GasContext())
            {
                var adiabatic = db.AdiabaticConstants.ToList();
                var vander = db.VanderWaalsCoeffses.ToList();
                var temperatures = db.GasTemperatures.ToList();
                var results =
                    db.Results.Include(r => r.Gas).Include(r => r.User)
                        .ToList()
                        .Select(s => new
                        {
                            s.Date,
                            UserName = s.User,
                            ModelingType = s.ModelingType == 1 ? "Дифференциальная" : "Интегральная",
                            GasName = s.Gas,
                            s.GasTemperature,
                            s.GasVolume,
                            s.EnvironmentPressure1,
                            s.EnvironmentPressure2,
                            adiabatic.FirstOrDefault(a => a.GasId == s.GasId).K,
                            vander.FirstOrDefault(v => v.GasId == s.GasId).A,
                            vander.FirstOrDefault(v => v.GasId == s.GasId).B,
                            temperatures.FirstOrDefault(t => t.GasId == s.GasId && t.Temperature == s.GasTemperature).Cp,
                            s.ModelingResult,
                            s.Radius,
                            s.SolarRadiation,
                            s.TubeWeight,
                            s.HeatQuantity,
                            s.MeltingTime
                        });
                if (date != null)
                {
                    results = results.Where(r => r.Date.Date == date);
                }
                if (user != null)
                {
                    results = results.Where(r => r.UserName.Id == user.Id);
                }
                if (gas != null)
                {
                    results = results.Where(r => r.GasName.Id == gas.Id);
                }
                if (modelingType != null)
                {
                    results = results.Where(r => r.ModelingType.ToLower().Contains(modelingType.ToLower()));
                }
                if (p1 != null)
                {
                    results = results.Where(r => r.EnvironmentPressure1 == p1);
                }
                if (p2 != null)
                {
                    results = results.Where(r => r.EnvironmentPressure2 == p2);
                }
                dgvResults.DataSource = results.ToList();
                dgvResults.Columns["Date"].HeaderText = "Дата";
                dgvResults.Columns["UserName"].HeaderText = "Пользователь";
                dgvResults.Columns["ModelingType"].HeaderText = "Модель";
                dgvResults.Columns["GasName"].HeaderText = "Газ";
                dgvResults.Columns["GasTemperature"].HeaderText = "Температура газа";
                dgvResults.Columns["GasVolume"].HeaderText = "Объем газа";
                dgvResults.Columns["EnvironmentPressure1"].HeaderText = "P1";
                dgvResults.Columns["EnvironmentPressure2"].HeaderText = "P2";
                dgvResults.Columns["ModelingResult"].HeaderText = "T2-T1";
                dgvResults.Columns["Radius"].HeaderText = "r";
                dgvResults.Columns["SolarRadiation"].HeaderText = "N";
                dgvResults.Columns["TubeWeight"].HeaderText = "m";
                dgvResults.Columns["HeatQuantity"].HeaderText = "Q";
                dgvResults.Columns["MeltingTime"].HeaderText = "t";
                foreach (DataGridViewColumn column in dgvResults.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData(
                edDate.MaskCompleted ? DateTime.Parse(edDate.Text) : (DateTime?) null,
                cmbUser.SelectedIndex > 0 ? cmbUser.SelectedItem as User : null,
                cmbGasType.SelectedIndex > 0 ? cmbGasType.SelectedItem as Gas : null,
                cmbFormula.SelectedIndex > 0 ? cmbFormula.SelectedItem.ToString() : null,
                edP1.Value != 0 ? edP1.Value : (decimal?)null,
                edP2.Value != 0 ? edP2.Value : (decimal?)null);
        }

        private void miDoc_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "pdf";
                sfd.Filter = "PDF files | *.pdf";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    ExportHelper.SavePdf(dgvResults, sfd.FileName);
                    Process.Start(sfd.FileName);
                }
            }
        }
    }
}
