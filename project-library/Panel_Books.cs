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
    public partial class Panel_Books : OverlapUserControl
    {
        private Form_Main _form_main;

        public Panel_Books(Form_Main form_main)
        {
            InitializeComponent();
            _form_main = form_main;
        }

        private void Button_Insert_Book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Insert_Book);
        }

        private void Button_Insert_Book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Insert_Book);
        }

        private void Button_Find_Book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Find_Book);
        }

        private void Button_Find_Book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Find_Book);
        }

        private void Button_Insert_Book_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(_form_main.GetForm("Form_Insert_Book"));
        }

        private void Button_Find_Book_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(_form_main.GetForm("Form_Search"));
        }
    }
}
