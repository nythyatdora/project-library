using System;
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
    public partial class Form_Return : Form
    {
        private Form_Main _form_main;

        public Form_Return()
        {
            InitializeComponent();
        }

        public Form_Return(Form_Main form_main)
        {
            InitializeComponent();
            _form_main = form_main;
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
            ControlMethod.CloseForm(this);
        }

        private void Label_View_Table_Readers_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Table_Readers"));
            ControlMethod.LoadForm(new Form_Table("Readers"));
        }

        private void Label_View_Table_Books_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Table_Books"));
            ControlMethod.LoadForm(new Form_Table("Books"));
        }

        private void Label_Next_Click(object sender, EventArgs e)
        {
            MessageBox.Show("all found!");
            ControlMethod.LoadForm(new Form_Return_Table());
            ControlMethod.CloseForm(this);
        }

        private void Label_Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("search result: ");
        }
    }
}
