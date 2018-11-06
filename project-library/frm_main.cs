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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void SetImageButtonEnter_Small(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Small;
        }

        private void SetImageButtonLeave_Small(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Small;
        }


        private void SetImageButtonEnter_Big(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Big;
        }

        private void SetImageButtonLeave_Big(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Big;
        }

        private void Label_Dropmenu_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Dropmenu);
        }

        private void Label_Dropmenu_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Dropmenu);
        }

        private void Label_Home_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Home);
        }

        private void Label_Home_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Home);
        }

        private void Label_Borrow_Return_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Borrow_Return);
        }

        private void Label_Borrow_Return_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Borrow_Return);
        }

        private void Label_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Books);
        }

        private void Label_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Books);
        }

        private void Label_Category_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Category);
        }

        private void Label_Category_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Category);
        }

        private void Label_Readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Readers);
        }

        private void Label_Readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Readers);
        }

        private void Label_Membership_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Membership);
        }

        private void Label_Membership_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Membership);
        }

        private void Label_Myprofile_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Myprofile);
        }

        private void Label_Myprofile_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Myprofile);
        }

        private void Label_Report_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Report);
        }

        private void Label_Report_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Report);
        }

        private void Label_Exit_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Exit);
        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Exit);
        }

        private void Label_Dropmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label_Dropmenu.ContextMenuStrip = ContextMenuStrip_Main;
                Label_Dropmenu.ContextMenuStrip.Show(Label_Dropmenu,5,25);
            }
        }

        private void Button_Borrow_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Small(Button_Borrow);
        }

        private void Button_Borrow_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Small(Button_Borrow);
        }

        private void Button_Return_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Small(Button_Return);
        }

        private void Button_Return_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Small(Button_Return);
        }

        private void Button_Books_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Big(Button_Books);
        }

        private void Button_Books_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Big(Button_Books);
        }

        private void Button_Category_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Big(Button_Category);
        }

        private void Button_Category_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Big(Button_Category);
        }

        private void Button_Readers_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Small(Button_Readers);
        }

        private void Button_Readers_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Small(Button_Readers);
        }

        private void Button_Membership_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Small(Button_Membership);
        }

        private void Button_Membership_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Small(Button_Membership);
        }

        private void Button_Myprofile_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Big(Button_Myprofile);
        }

        private void Button_Myprofile_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Big(Button_Myprofile);
        }

        private void Button_Report_MouseEnter(object sender, EventArgs e)
        {
            SetImageButtonEnter_Big(Button_Report);
        }

        private void Button_Report_MouseLeave(object sender, EventArgs e)
        {
            SetImageButtonLeave_Big(Button_Report);
        }
    }
}
