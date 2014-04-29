﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pl2.rainbow.description;

namespace pl2.rainbow.form.gdi.components
{
    public partial class Cell : UserControl
    {
        public Cell()
        {
            InitializeComponent();
        }

        [Browsable( true ) , Description( "Фаза обработки" ) , Category( "Data" )]
        public Phase_direction phase { get; set; }

        private void rename_menu_item_Click(object sender , EventArgs e)
        {
            single_button.Text = pl2ide.project.rainbow.form.simple.input.string_value.input.get( "Введите новое значение" , single_button.Text );
        }
    }
}