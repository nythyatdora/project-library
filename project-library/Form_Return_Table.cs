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
    public partial class Form_Return_Table : Form
    {
        public Form_Return_Table()
        {
            InitializeComponent();
        }

        public Form_Return_Table(String title)
        {
            InitializeComponent();
            Label_Reader_Name.Text = title;
        }

        private void Label_Return_Book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Return_Book);
        }

        private void Label_Return_Book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Return_Book);
        }

        private void Label_Update_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Update);
        }

        private void Label_Update_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Update);
        }

        private void Label_Borrow_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Borrow);
        }

        private void Label_Borrow_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Borrow);
        }

        private void Label_View_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View);
        }

        private void Label_View_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View);
        }

        private void Label_Refresh_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Refresh);
        }

        private void Label_Refresh_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Refresh);
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

        private void Label_Return_Book_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirm Process?", "", MessageBoxButtons.YesNo);
            // ControlMethod.CloseForm(this);
        }
    }
}
