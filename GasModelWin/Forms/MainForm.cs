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

namespace GasModelWin
{
    public partial class Form1 : Form
    {
        private GasContext context;

        public Form1()
        {
            InitializeComponent();
            Database.SetInitializer(new GasContextInitializer());
            using (context = new GasContext())
            {
                var users = context.Users;
                MessageBox.Show(users.Count().ToString());
            }
        }
    }
}
