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
    public partial class Form_New_Management : Form
    {
        public Form_New_Management()
        {
            InitializeComponent();
        }

        private void Button_Register_Staff_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Register_Staff);
        }

        private void Button_Register_Staff_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Register_Staff);
        }

        private void Button_Manage_Staff_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Round(Button_Manage_Staff);
        }

        private void Button_Manage_Staff_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Round(Button_Manage_Staff);
        }

        private void Button_Register_Staff_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(null);
        }

        private void Button_Manage_Staff_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(null);
        }
    }
}
