using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pl2.project
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
            Application.Run( new main_form() );
            // Application.Run( new rainbow_window() );
            }
        }
    }
