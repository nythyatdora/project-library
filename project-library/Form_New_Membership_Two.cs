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
    public partial class Form_New_Membership_Two : Form
    {
        public Form_New_Membership_Two()
        {
            InitializeComponent();
        }

        private void Label_View_Table_Membership_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Membership);
        }

        private void Label_View_Table_Membership_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Membership);
        }

        private void Label_View_Table_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Books);
        }

        private void Label_View_Table_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Books);
        }

        private void Label_Confirm_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Confirm);
        }

        private void Label_Confirm_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Confirm);
        }

        private void Label_Reset_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Reset);
        }

        private void Label_Reset_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Reset);
        }

        private void Label_Close_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Close);
        }

        private void Label_Close_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Close);
        }
    }
}
