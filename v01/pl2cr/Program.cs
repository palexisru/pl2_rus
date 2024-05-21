using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using pl2cr.forms;

namespace pl2cr
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MDIParent ft;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ft = new MDIParent();
            Application.Run(ft);
        }
    }
}
