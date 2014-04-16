using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2ide
    {
    public partial class Form_PL2_IDE : Form
        {
        public Form_PL2_IDE()
            {
            InitializeComponent();
            }

        private void exit_IDE_menu_item_Click(object sender , EventArgs e)
            {
               CancelEventArgs make = new CancelEventArgs();
               Application.Exit(make);
            }
        }
    }
