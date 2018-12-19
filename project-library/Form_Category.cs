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
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();
        }

        private void Button_Science_Fiction_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Science_Fiction);
        }

        private void Button_Science_Fiction_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Science_Fiction);
        }

        private void Button_Drama_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Drama);
        }

        private void Button_Drama_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Drama);
        }

        private void Button_Mystery_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Mystery);
        }

        private void Button_Mystery_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Mystery);
        }

        private void Button_Comics_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Comics);
        }

        private void Button_Comics_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Comics);
        }

        private void Button_Math_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Math);
        }

        private void Button_Math_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Math);
        }

        private void Button_Horror_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Horror);
        }

        private void Button_Horror_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Horror);
        }

        private void Button_History_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_History);
        }

        private void Button_History_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_History);
        }

        private void Button_Fantasy_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Fantasy);
        }

        private void Button_Fantasy_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Fantasy);
        }

        private void Button_Adventure_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Adventure);
        }

        private void Button_Adventure_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Adventure);
        }

        private void Button_Science_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonEnter_Square(Button_Science);
        }

        private void Button_Science_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetImageButtonLeave_Square(Button_Science);
        }

        private void Button_Science_Fiction_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Science Fiction"));
        }

        private void Button_Drama_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Drama"));
        }

        private void Button_Mystery_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Mystery"));
        }

        private void Button_Comics_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Comic"));
        }

        private void Button_Math_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Math"));
        }

        private void Button_Horror_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Horror"));
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("History"));
        }

        private void Button_Fantasy_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Fantasy"));
        }

        private void Button_Adventure_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Adventure"));
        }

        private void Button_Science_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Science"));
        }
    }
}
