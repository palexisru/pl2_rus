using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pl2.ide.project.file.meta.form.mode.classic;

namespace pl2.ide.project.file.meta.form.sdi
    {
    public partial class SDI : Form
        {
        private Default default_linked_object = new Default();
        public SDI()
            {
                InitializeComponent();
                default_linked_object.prepare_data_grid(data_values);
                form_data = default_linked_object;
            }
        [Browsable( true ) , Description( "внутренние значения разных типов" ) , Category( "Data" )]
        public Default default_values
            {
            get
                {
                     data_values.SelectedObject = default_linked_object;
                     return default_linked_object;
                }
            }

        [Browsable( true ) , Description( "название формы" ) , Category( "Data" )]
        public string tytle
            {
            get
                {
                    return Text;
                }
            set
                {
                    Text = value;
                }
            }

        [Browsable( true ) , Description( "данные в форме" ) , Category( "Data" )]
        public object form_data
            {
                get{
                    return data_values.SelectedObject;
                }
                set{
                    data_values.SelectedObject = value;
                }
            }

        private void toolStripMenuItem1_Click(object sender , EventArgs e)
            {

            }

        private void tool_usage_Click(object sender , EventArgs e)
            {
 
            }

        private void data_values_Click(object sender , EventArgs e)
            {
            }

        private void tool_action_Click(object sender , EventArgs e)
            {
            default_linked_object.prepare_data_grid( data_values );
            MessageBox.Show( "начало " + data_values.SelectedObject.ToString() );
            }
        }
    }
