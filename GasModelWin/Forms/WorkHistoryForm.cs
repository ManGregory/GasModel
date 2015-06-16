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
using ZedGraph;

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
            using (var db = new GasContext())
            {
                var results =
                    db.Results.Include(r => r.Gas).Include(r => r.User).ToList();
                dgvResults.DataSource = results;
            }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
