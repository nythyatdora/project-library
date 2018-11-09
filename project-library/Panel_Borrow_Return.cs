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
    public partial class Panel_Borrow_Return : OverlapUserControl
    {
        public Panel_Borrow_Return()
        {
            InitializeComponent();
        }

        private void Button_Borrow_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Borrow);
        }

        private void Button_Borrow_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Borrow);
        }

        private void Button_Return_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Return);
        }

        private void Button_Return_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Return);
        }
    }
}
