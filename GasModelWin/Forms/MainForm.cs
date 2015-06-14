using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
