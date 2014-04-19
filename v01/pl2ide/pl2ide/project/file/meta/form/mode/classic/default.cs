using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using pl2ide.project.file.meta.form;

namespace pl2ide.project.file.meta.form.mode.classic
    {

    public enum Enumerated
    {
        ноль, один, два, три, четыре
    }
    public class Default : Data
        {
        private Int32 integer_value_private = 1;
        private float real_value_private = (float) Math.PI;
        private bool logical_value_private = true;
        private string string_value_private = "тестовая строка";
        private Enumerated group_value_private;

        [Browsable( true ) , Description( "целое число со знаком" ) , Category( "Data" )]
        public Int32 число_целое { get; set; }

        [Browsable( true ) , Description( "действительное число с точкой" ) , Category( "Data" )]
        public float число_действительное { get; set; }

        [Browsable( true ) , Description( "логическое" ) , Category( "Data" )]
        public bool логическое { get; set; }

        [Browsable( true ) , Description( "строка для изменения ввода" ) , Category( "Data" )]
        public string строка { get; set; }

        [Browsable( true ) , Description( "группа выбора из нескольких значений" ) , Category( "Data" )]
        public Enumerated группа_выбора { get; set; }

        [Browsable( true ) , Description( "дата года" ) , Category( "Data" )]
        public DateTime дата_года { get; set; }

        [Browsable( false )]
        public void prepare_data_grid(PropertyGrid data)
            {
            число_действительное = real_value_private;
            строка = string_value_private;
            data.SelectedObject = this;
            }
        [Browsable( false )]
        public void Show(string message = "Введите данные")
            {
                pl2ide.project.file.meta.form.sdi.SDI sdi_data_form = new pl2ide.project.file.meta.form.sdi.SDI();
                sdi_data_form.form_data = this;
                sdi_data_form.tytle = message;
                sdi_data_form.Show();
            }
        }
    }
