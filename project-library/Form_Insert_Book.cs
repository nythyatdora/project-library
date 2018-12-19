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
    public partial class Form_Insert_Book : Form
    {
        private Form_Main _form_main;

        public Form_Insert_Book()
        {
            InitializeComponent();
        }

        public Form_Insert_Book(Form_Main form_main)
        {
            InitializeComponent();
            _form_main = form_main;
        }

        private void Label_Import_External_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Import_External);
        }

        private void Label_Import_External_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Import_External);
        }

        private void Label_View_Table_Book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Book);
        }

        private void Label_View_Table_Book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Book);
        }

        private void Label_Upload_Bookcover_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Upload_Bookcover);
        }

        private void Label_Upload_Bookcover_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Upload_Bookcover);
        }

        private void Label_Reset_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Reset);
        }

        private void Label_Reset_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Reset);
        }

        private void Label_Confirm_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Confirm);
        }

        private void Label_Confirm_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Confirm);
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

        private void Label_Upload_Bookcover_Click(object sender, EventArgs e)
        {
            OpenFileDialog_Bookcover.ShowDialog();
        }

        private void Label_Import_External_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Import_Text"));
            ControlMethod.LoadForm(new Form_Import_Text());
        }

        private void Label_View_Table_Book_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Table_Books"));
            ControlMethod.LoadForm(new Form_Table("Books"));
        }

        private void Label_Confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("book has inserted!");
        }
    }
}
