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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Database.SetInitializer(new GasContextInitializer());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // проверка прав пользователя
            var user = GetUser(txtLogin.Text, txtPassword.Text);
            if (user != null)
            {
                Current.CurrentUser = user;
                Visible = false;
                var mainForm = new MainForm(this);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
            }
        }

        /// <summary>
        /// Поиск пользователя в базе
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Пользователь</returns>
        private User GetUser(string login, string password)
        {
            using (var db = new GasContext())
            {
                return db.UserLoginses.Include(u => u.User).Where(u => u.Login == login && u.Password == password)
                    .Select(u => u.User).FirstOrDefault();
            }
        }
    }
}
