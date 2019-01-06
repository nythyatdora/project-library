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
        public Boolean IsLogSuccessed { private set; get; }

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

        private void Label_Confirm_Click(object sender, EventArgs e)
        {
            Boolean validUsername = false;
            Boolean validPassword = false;

            if (Text_Username.Text == "admin")
                validUsername = true;
            else
            {
                validUsername = false;
                
                if(Text_Username.Text == "")
                    MessageBox.Show("missing field: username!");
                else
                    MessageBox.Show("invalid username!");
            }

            if (Text_Password.Text == "admin")
            {
                validPassword = true;
            }
            else
            {
                validPassword = false;
                if (Text_Username.Text == "")
                    MessageBox.Show("missing field: password!");
                else
                    MessageBox.Show("invalid password!");
            }

            if(validUsername)
            {
                if(validPassword)
                {
                    IsLogSuccessed = true;
                    MessageBox.Show("login successful!");
                    ControlMethod.LoadForm(new Form_New_Main());
                    this.Hide();
                }
            }
        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            IsLogSuccessed = false;
            this.Close();
        }  
    }
}
