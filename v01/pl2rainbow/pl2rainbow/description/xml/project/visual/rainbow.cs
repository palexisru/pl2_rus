using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pl2.rainbow.description.xml.project.visual
{
    public partial class Rainbow : Form
    {
        public Rainbow()
        {
            InitializeComponent();
        }

        private void Rainbow_Load(object sender , EventArgs e)
        {
        }

        private void Rainbow_Shown(object sender , EventArgs e)
        {
            rainbow_data.create_default_project();
        }

        private void debug_save_button_Click(object sender , EventArgs e)
        {
            rainbow_data.WriteXml("C:\\pl2_rus\\test\\empty.xml");
            rainbow_data.WriteXmlSchema( "C:\\pl2_rus\\test\\empty.xsd" );
        }
    }
}
