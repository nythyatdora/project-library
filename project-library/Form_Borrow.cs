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
    public partial class Form_Borrow : Form
    {
        public Form_Borrow()
        {
            InitializeComponent();
        }

        private void Label_Add_New_Reader_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Add_New_Reader);
        }

        private void Label_Add_New_Reader_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Add_New_Reader);
        }

        private void Label_Add_New_Book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Add_New_Book);
        }

        private void Label_Add_New_Book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Add_New_Book);
        }

        private void Label_View_Table_Readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Readers);
        }

        private void Label_View_Table_Readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Readers);
        }

        private void Label_View_Table_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Books);
        }

        private void Label_View_Table_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Books);
        }

        private void Label_Search_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Search);
        }

        private void Label_Search_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Search);
        }

        private void Label_Reset_Search_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Reset_Search);
        }

        private void Label_Reset_Search_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Reset_Search);
        }

        private void Label_Next_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Next);
        }

        private void Label_Next_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Next);
        }

        private void Label_Back_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Back);
        }

        private void Label_Back_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Back);
        }

        private void Label_Close_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Close);
        }

        private void Label_Close_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Close);
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
