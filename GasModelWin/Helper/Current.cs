using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasModelWin.Models;

namespace GasModelWin.Helper
{
    /// <summary>
    /// Класс для хранения информации по текущему пользователю
    /// </summary>
    static class Current
    {
        public static User CurrentUser { get; set; }
    }
}
