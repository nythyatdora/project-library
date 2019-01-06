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
    public partial class Form_New_Home : Form
    {
        private Form_New_Main _form_main;

        public Form_New_Home(Form_New_Main form_main)
        {
            InitializeComponent();
            _form_main = form_main;
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

        private void Button_Management_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Management);
        }

        private void Button_Management_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Management);
        }

        private void Button_Report_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Full(Button_Report);
        }

        private void Button_Report_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Full(Button_Report);
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Borrow"));
            ControlMethod.LoadForm(new Form_New_Borrow());
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Return"));
            ControlMethod.LoadForm(new Form_New_Return());
        }

        private void Button_Books_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(_form_main.Panel_Main, _form_main.GetForm("Form_Books"));
        }

        private void Button_Category_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(_form_main.Panel_Main, _form_main.GetForm("Form_Category"));
        }

        private void Button_Readers_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(_form_main.Panel_Main, _form_main.GetForm("Form_Readers"));
        }

        private void Button_Membership_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(_form_main.GetForm("Form_Membership"));
            ControlMethod.LoadForm(new Form_New_Membership_One());
        }

        private void Button_Management_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(_form_main.Panel_Main, _form_main.GetForm("Form_Myprofile"));
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {

        }
    }
}
