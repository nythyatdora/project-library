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
    public partial class Frm_Proceed_Borrow : Form
    {
        public Frm_Proceed_Borrow()
        {
            InitializeComponent();
        }

        private void label_add_new_reader_MouseEnter(object sender, EventArgs e)
        {
            label_add_new_reader.ForeColor = Color.Green;
        }

        private void label_add_new_reader_MouseLeave(object sender, EventArgs e)
        {
            label_add_new_reader.ForeColor = Color.White;
        }

        private void label_proceed_MouseEnter(object sender, EventArgs e)
        {
            label_proceed.ForeColor = Color.Green;
        }

        private void label_proceed_MouseLeave(object sender, EventArgs e)
        {
            label_proceed.ForeColor = Color.White;
        }

        private void label_view_profile_MouseEnter(object sender, EventArgs e)
        {
            label_view_profile.ForeColor = Color.Green;
        }

        private void label_view_profile_MouseLeave(object sender, EventArgs e)
        {
            label_view_profile.ForeColor = Color.White;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_view_book_MouseEnter(object sender, EventArgs e)
        {
            label_view_book.ForeColor = Color.Green;
        }

        private void label_view_book_MouseLeave(object sender, EventArgs e)
        {
            label_view_book.ForeColor = Color.White;
        }
    }
}
