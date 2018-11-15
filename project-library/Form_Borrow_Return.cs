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
    public partial class Form_Borrow_Return : Form
    {
        private Form_Main _form_main;
        public Form_Borrow_Return(Form_Main form_main)
        {
            InitializeComponent();
            _form_main = form_main;
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

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(_form_main.GetForm("Form_Borrow"));
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(_form_main.GetForm("Form_Return"));
        }
    }
}
