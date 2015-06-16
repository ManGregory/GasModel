using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasModelWin.Helper;
using GasModelWin.Models;

namespace GasModelWin.Forms
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            Closed += (sender, args) => _loginForm.Close();
            rbDiff.Checked = true;
            LoadGases();
        }

        private void LoadGases()
        {
            using (var db = new GasContext())
            {
                db.Gases.Load();
                cmbGasType.DataSource = null;
                cmbGasType.DataSource = db.Gases.Local;
            }
        }

        private void grpOutput_Enter(object sender, EventArgs e)
        {

        }

        private void rbDiff_CheckedChanged(object sender, EventArgs e)
        {
            txtP1.Enabled = txtP2.Enabled = rbIntegr.Checked;
            txtGasVolume.Enabled = rbDiff.Checked;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var gas = cmbGasType.SelectedItem as Gas;
            if (gas != null)
            {
                FillGasInfo(gas);
                var result = CreateResult(gas);
                result.ModelingResult = Result.Calc(
                    result,
                    txtCp.Value,
                    txtACoeff.Value,
                    txtBCoeff.Value,
                    txtResultP1.Value,
                    txtResultP2.Value,
                    txtAdiabatic.Value);
                using (var db = new GasContext())
                {
                    db.Results.Add(result);
                    Save(db);
                }
                txtResult.Text = result.ModelingResult.ToString("F");
            }
        }

        private void Save(GasContext db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        private Result CreateResult(Gas gas)
        {
            return new Result
            {
                Date = DateTime.Now,
                EnvironmentPressure1 = txtP1.Value,
                EnvironmentPressure2 = txtP2.Value,
                GasId = gas.Id,
                GasTemperature = edTemperature.Value,
                GasVolume = txtGasVolume.Value,
                ModelingType = rbIntegr.Checked ? 0 : 1,
                UserId = Current.CurrentUser.Id
            };
        }

        private void FillGasInfo(Gas gas)
        {
            using (var db = new GasContext())
            {
                txtGasType.Text = gas.Name;
                txtFormula.Text = rbIntegr.Checked ? "Интегральная" : "Дифференциальная";
                txtTemperatureResult.Text = edTemperature.Text;
                var adiabaticConstant = db.AdiabaticConstants.FirstOrDefault(ac => ac.GasId == gas.Id);
                if (adiabaticConstant != null)
                {
                    txtAdiabatic.Value = adiabaticConstant.K;
                }
                var coeffs = db.VanderWaalsCoeffses.FirstOrDefault(v => v.GasId == gas.Id);
                if (coeffs != null)
                {
                    txtACoeff.Value = coeffs.A;
                    txtBCoeff.Value = coeffs.B;
                }
                var cp =
                    db.GasTemperatures.FirstOrDefault(g => g.GasId == gas.Id && g.Temperature == edTemperature.Value);
                if (cp != null)
                {
                    txtCp.Value = cp.Cp;
                }
                if (rbIntegr.Checked)
                {
                    txtResultP1.Value = txtP1.Value;
                    txtResultP2.Value = txtP2.Value;
                }
            }
        }
    }
}
