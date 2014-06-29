﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2.rainbow.form.gdi.sdi.property
{
    public partial class Options : Form
    {
        public pl2.rainbow.Options options { get; set; }
        public Options(pl2.rainbow.Options new_options)
        {
            InitializeComponent();
            options = new_options;
            load_current_values();

        }

        private void load_current_values()
        {
            maximal_colors.Value = options.number_of_levels;
            central_visible_check_box.Checked = options.center_allways_visible;
            special_check_box.Checked = false; // options.visible_specials == ;
            symmetric_check_box.Checked = options.visible_symmetric;
        }

        private void button_ok_Click(object sender , EventArgs e)
        {
            options.number_of_levels = (int)maximal_colors.Value;
            options.center_allways_visible = central_visible_check_box.Checked;
            // options.visible_specials = special_check_box.Checked;
            options.visible_symmetric = symmetric_check_box.Checked;
            Close();
        }

        private void button_cancel_Click(object sender , EventArgs e)
        {
            Close();
        }

    }
}
