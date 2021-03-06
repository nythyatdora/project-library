﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_library.Class;

namespace project_library
{
    public partial class Panel_Readers : OverlapUserControl
    {
        public Panel_Readers()
        {
            InitializeComponent();
        }

        private void Button_Insert_Reader_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Insert_Reader);
        }

        private void Button_Insert_Reader_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Insert_Reader);
        }

        private void Button_Find_Reader_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Find_Reader);
        }

        private void Button_Find_Reader_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Find_Reader);
        }
    }
}
