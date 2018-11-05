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
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_search_MouseEnter(object sender, EventArgs e)
        {
            label_search.ForeColor = Color.Green;
        }

        private void label_search_MouseLeave(object sender, EventArgs e)
        {
            label_search.ForeColor = Color.White;
        }

        private void label_reset_MouseEnter(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.Green;
        }

        private void label_reset_MouseLeave(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.White;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
