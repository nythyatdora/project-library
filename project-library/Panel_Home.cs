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
    public partial class Panel_Home : OverlapUserControl
    {
        public Panel_Home()
        {
            InitializeComponent();
        }

        private void Button_Borrow_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Half(Button_Borrow);
        }

        private void Button_Borrow_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Half(Button_Borrow);
        }

        private void Button_Return_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Half(Button_Return);
        }

        private void Button_Return_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Half(Button_Return);
        }

        private void Button_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Books);
        }

        private void Button_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Books);
        }

        private void Button_Category_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Category);
        }

        private void Button_Category_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Category);
        }

        private void Button_Readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Half(Button_Readers);
        }

        private void Button_Readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Half(Button_Readers);
        }

        private void Button_Membership_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Half(Button_Membership);
        }

        private void Button_Membership_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Half(Button_Membership);
        }

        private void Button_Myprofile_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Myprofile);
        }

        private void Button_Myprofile_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Myprofile);
        }

        private void Button_Report_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Report);
        }

        private void Button_Report_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Report);
        }
    }
}
