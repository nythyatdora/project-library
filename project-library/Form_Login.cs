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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Label_Confirm_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Confirm);
        }

        private void Label_Confirm_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Confirm);
        }

        private void Label_Exit_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Exit);
        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Exit);
        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
