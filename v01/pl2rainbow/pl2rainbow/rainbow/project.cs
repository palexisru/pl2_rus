using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.rainbow.description;

namespace pl2.rainbow
    {
    public class Project
        {
            public string URL;
            public string filename;
            public int number_of_colors = 3;
            public bool center_allwase_visible = false;
            public pl2.rainbow.description.Abstraction_level current_center = Abstraction_level.Interface_target;
            public bool specials_visible = true;
            
        }
    }
