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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_dropmenu_MouseEnter(object sender, EventArgs e)
        {
            label_dropmenu.ForeColor = Color.Green;
        }

        private void label_dropmenu_MouseLeave(object sender, EventArgs e)
        {
            label_dropmenu.ForeColor = Color.White;
        }

        private void label_home_MouseEnter(object sender, EventArgs e)
        {
            label_home.ForeColor = Color.Green;
        }

        private void label_home_MouseLeave(object sender, EventArgs e)
        {
            label_home.ForeColor = Color.White;
        }

        private void label_borrow_return_MouseEnter(object sender, EventArgs e)
        {
            label_borrow_return.ForeColor = Color.Green;
        }

        private void label_borrow_return_MouseLeave(object sender, EventArgs e)
        {
            label_borrow_return.ForeColor = Color.White;
        }

        private void label_books_MouseEnter(object sender, EventArgs e)
        {
            label_books.ForeColor = Color.Green;
        }

        private void label_books_MouseLeave(object sender, EventArgs e)
        {
            label_books.ForeColor = Color.White;
        }

        private void label_category_MouseEnter(object sender, EventArgs e)
        {
            label_category.ForeColor = Color.Green;
        }

        private void label_category_MouseLeave(object sender, EventArgs e)
        {
            label_category.ForeColor = Color.White;
        }

        private void label_readers_MouseEnter(object sender, EventArgs e)
        {
            label_readers.ForeColor = Color.Green;
        }

        private void label_readers_MouseLeave(object sender, EventArgs e)
        {
            label_readers.ForeColor = Color.White;
        }

        private void label_membership_MouseEnter(object sender, EventArgs e)
        {
            label_membership.ForeColor = Color.Green;
        }

        private void label_membership_MouseLeave(object sender, EventArgs e)
        {
            label_membership.ForeColor = Color.White;
        }

        private void label_myprofile_MouseEnter(object sender, EventArgs e)
        {
            label_myprofile.ForeColor = Color.Green;
        }

        private void label_myprofile_MouseLeave(object sender, EventArgs e)
        {
            label_myprofile.ForeColor = Color.White;
        }

        private void label_report_MouseEnter(object sender, EventArgs e)
        {
            label_report.ForeColor = Color.Green;
        }

        private void label_report_MouseLeave(object sender, EventArgs e)
        {
            label_report.ForeColor = Color.White;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Green;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_dropmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label_dropmenu.ContextMenuStrip = contextMenuStrip;
                label_dropmenu.ContextMenuStrip.Show(label_dropmenu,5,25);
            }
        }
    }
}
