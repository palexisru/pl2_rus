using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2ide.project.rainbow.form.simple.input.string_value.gdi
    {
    public partial class input_box : Form
        {
            public string message_string {get; set;}
            public string return_string {get; set;}
            public input_box()
            {
                InitializeComponent();
            }

            private void input_box_Activated(object sender , EventArgs e)
                {
                    message_text.Text = message_string;
                    input_text_box.Text = return_string;
                }
        }

    }
