using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2ide.project.rainbow.form.simple.input.string_value
{
    public class input
    {
        public static string get(string message , string default_string)
        {
            pl2ide.project.rainbow.form.simple.input.string_value.gdi.input_box window = new pl2ide.project.rainbow.form.simple.input.string_value.gdi.input_box();
            window.return_string = default_string;
            window.message_string = message;
            window.ShowDialog();
            if (window.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return window.return_string;
            }
            else
            {
                return default_string;
            }
        }
    }
}
