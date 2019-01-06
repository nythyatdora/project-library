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
    public partial class Form_New_Proceed_Borrow : Form
    {
        public Form_New_Proceed_Borrow()
        {
            InitializeComponent();
        }

        private void Label_View_Table_ProccedBorrow_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_ProccedBorrow);
        }

        private void Label_View_Table_ProccedBorrow_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_ProccedBorrow);
        }

        private void Label_View_Table_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_View_Table_Books);
        }

        private void Label_View_Table_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_View_Table_Books);
        }

        private void Label_Proceed_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Proceed);
        }

        private void Label_Proceed_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Proceed);
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
