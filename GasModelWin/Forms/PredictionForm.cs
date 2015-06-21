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
using GasModelWin.Helper;
using GasModelWin.Models;

namespace GasModelWin.Forms
{
    public partial class PredictionForm : Form
    {
        private Result _result;

        public PredictionForm(Result result)
        {
            InitializeComponent();
            _result = result;
            // загрузка результата
            LoadResult();
        }

        /// <summary>
        /// Загрузка результатов моделирования
        /// </summary>
        private void LoadResult()
        {
            edRadius.Value = _result.Radius;
            edSolarRadiation.Value = _result.SolarRadiation;
            edTubeWeight.Value = _result.TubeWeight;
            edHeatQuantity.Value = _result.HeatQuantity;
            edMeltingTime.Value = _result.MeltingTime;
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Получение результатов прогноза
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreatePrediction_Click(object sender, EventArgs e)
        {
            _result.Radius = edRadius.Value;
            _result.SolarRadiation = edSolarRadiation.Value;
            // масса лединой пробки
            _result.TubeWeight = Result.GetTubeWeight(_result);
            // количество теплоты
            _result.HeatQuantity = Result.GetHeatQuantity(_result);
            // время таяния
            _result.MeltingTime = Result.GetMeltingTime(_result);
            // сохранение результатов в базу
            using (var db = new GasContext())
            {
                db.Results.Attach(_result);
                db.Entry(_result).State = EntityState.Modified;
                DbHelper.Save(db);
            }
            FillResult();
        }

        /// <summary>
        /// Заполнение результатов в базу
        /// </summary>
        private void FillResult()
        {
            edTubeWeight.Value = _result.TubeWeight;
            edHeatQuantity.Value = _result.HeatQuantity;
            edMeltingTime.Value = _result.MeltingTime;
        }
    }
}
