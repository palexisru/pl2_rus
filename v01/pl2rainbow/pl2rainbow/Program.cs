using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pl2.rainbow
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
            Application.Run( new pl2.rainbow.form.gdi.sdi.main.main_sdi_form() );
            // Application.Run( new rainbow_window() );
            }
        }
    }
