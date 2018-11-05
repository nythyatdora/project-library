using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_confirm_MouseEnter(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.Green;
        }

        private void label_confirm_MouseLeave(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.White;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Green;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }
    }
}
