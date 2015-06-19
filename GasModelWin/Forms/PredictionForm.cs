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
            LoadResult();
        }

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

        private void btnCreatePrediction_Click(object sender, EventArgs e)
        {
            _result.Radius = edRadius.Value;
            _result.SolarRadiation = edSolarRadiation.Value;
            _result.TubeWeight = Result.GetTubeWeight(_result);
            _result.HeatQuantity = Result.GetHeatQuantity(_result);
            _result.MeltingTime = Result.GetMeltingTime(_result);
            using (var db = new GasContext())
            {
                db.Results.Attach(_result);
                db.Entry(_result).State = EntityState.Modified;
                DbHelper.Save(db);
            }
            FillResult();
        }

        private void FillResult()
        {
            edTubeWeight.Value = _result.TubeWeight;
            edHeatQuantity.Value = _result.HeatQuantity;
            edMeltingTime.Value = _result.MeltingTime;
        }
    }
}
