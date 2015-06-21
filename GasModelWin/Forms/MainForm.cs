using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using GasModelWin.Helper;
using GasModelWin.Models;

namespace GasModelWin.Forms
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;
        /// <summary>
        /// Результат моделирования
        /// </summary>
        private Result _result;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            Closed += (sender, args) => _loginForm.Close();
            rbDiff.Checked = true;
            LoadGases();
            btnPrediction.Enabled = false;
        }

        /// <summary>
        /// Загрузка типов газа в выпадающий список
        /// </summary>
        private void LoadGases()
        {
            using (var db = new GasContext())
            {
                db.Gases.Load();
                cmbGasType.DataSource = null;
                cmbGasType.DataSource = db.Gases.Local;
            }
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

        /// <summary>
        /// Моделирование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // проверка ввода
            var mes = VerifyInput();
            if (!string.IsNullOrWhiteSpace(mes))
            {
                MessageBox.Show(mes);
                return;
            }
            var gas = cmbGasType.SelectedItem as Gas;
            if (gas != null)
            {
                // заполнение информации о газе
                FillGasInfo(gas);
                // получение начальных результатов моделирования
                var result = CreateResult(gas);
                // моделирования
                result.ModelingResult = Result.Calc(
                    result,
                    txtCp.Value,
                    txtACoeff.Value,
                    txtBCoeff.Value,
                    txtResultP1.Value,
                    txtResultP2.Value,
                    txtAdiabatic.Value);
                // сохранение результата в базу
                using (var db = new GasContext())
                {
                    db.Results.Add(result);
                    DbHelper.Save(db);
                }
                _result = result;
                txtResult.Text = result.ModelingResult.ToString("F4");
                btnPrediction.Enabled = _result != null;
            }
        }

        /// <summary>
        /// Проверка введенных данных
        /// </summary>
        /// <returns></returns>
        private string VerifyInput()
        {
            var error = string.Empty;
            if (edTemperature.Value == 0 && rbIntegr.Checked)
            {
                error += "При интегральном эффекте Джоуля-Томпсона значение температуры должно быть отличным от нуля";
            }
            if (txtGasVolume.Value == 0 && rbDiff.Checked)
            {
                error += "При дифференциальном эффекте Джоуля-Томпсона значение объема газа должно быть отличным от нуля";
            }
            return error;
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

        /// <summary>
        /// Заполнение информации о типе газа
        /// </summary>
        /// <param name="gas"></param>
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

        private void miWorkHistory_Click(object sender, EventArgs e)
        {
            using (var workHistoryForm = new WorkHistoryForm())
            {
                workHistoryForm.ShowDialog(this);
            }
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            using (var predictionForm = new PredictionForm(_result))
            {
                predictionForm.ShowDialog(this);
            }
        }
    }
}
