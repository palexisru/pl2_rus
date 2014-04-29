using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pl2.rainbow.stars
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            pl2.rainbow.stars.sky.Main form = new pl2.rainbow.stars.sky.Main();
            Application.Run( form );
        }
    }
}
