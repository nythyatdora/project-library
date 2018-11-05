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
    public partial class Frm_Membership : Form
    {
        public Frm_Membership()
        {
            InitializeComponent();
        }

        private void label_view_table_readers_MouseEnter(object sender, EventArgs e)
        {
            label_view_table_readers.ForeColor = Color.Green;
        }

        private void label_view_table_readers_MouseLeave(object sender, EventArgs e)
        {
            label_view_table_readers.ForeColor = Color.White;
        }

        private void label_new_reader_MouseEnter(object sender, EventArgs e)
        {
            label_new_reader.ForeColor = Color.Green;
        }

        private void label_new_reader_MouseLeave(object sender, EventArgs e)
        {
            label_new_reader.ForeColor = Color.White;
        }

        private void label_search_MouseEnter(object sender, EventArgs e)
        {
            label_search.ForeColor = Color.Green;
        }

        private void label_search_MouseLeave(object sender, EventArgs e)
        {
            label_search.ForeColor = Color.White;
        }

        private void label_reset_search_MouseEnter(object sender, EventArgs e)
        {
            label_reset_search.ForeColor = Color.Green;
        }

        private void label_reset_search_MouseLeave(object sender, EventArgs e)
        {
            label_reset_search.ForeColor = Color.White;
        }

        private void label_confirm_MouseEnter(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.Green;
        }

        private void label_confirm_MouseLeave(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.White;
        }

        private void label_reset_MouseEnter(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.Green;
        }

        private void label_reset_MouseLeave(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.White;
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
    }
}
