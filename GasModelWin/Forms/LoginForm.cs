using System;
using System.Data.Entity;
using System.Linq;
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
            // установка инициализатора базы
            Database.SetInitializer(new GasContextInitializer());
        }

        /*private string GetTemperature()
        {
            var sb = new StringBuilder();                      
            sb.Append("context.GasTemperatures.AddRange(new[]{");
            var lines = File.ReadAllLines("1.txt");
            foreach (var line in lines)
            {
                var elems = line.Split(new[] {" ", "\t"}, StringSplitOptions.RemoveEmptyEntries);
                if (elems.Length >= 3)
                {
                    sb.AppendFormat("new GasTemperature {{GasId = {0}, Cp = {1}m, Temperature = {2}}}, ", elems[0],
                        elems[2].Replace(",", "."), elems[1]);
                }
            }
            sb.Append("});");
            return sb.ToString();
        }*/

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
