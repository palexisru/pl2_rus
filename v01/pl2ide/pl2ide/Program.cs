using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pl2ide
    {
    static class Program
        {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
            {

            Application.SetCompatibleTextRenderingDefault( false );
            Application.EnableVisualStyles();            

            Form ide = new Form_PL2_IDE();
            Form sdi = new pl2ide.project.file.meta.form.sdi.SDI();

            ide.Show();
            sdi.Show();
            Application.Run( ide );
            }
        }
    }
