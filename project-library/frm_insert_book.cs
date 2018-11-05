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
    public partial class Frm_Insert_Book : Form
    {
        public Frm_Insert_Book()
        {
            InitializeComponent();
        }

        private void label_import_external_MouseEnter(object sender, EventArgs e)
        {
            label_import_external.ForeColor = Color.Green;
        }

        private void label_import_external_MouseLeave(object sender, EventArgs e)
        {
            label_import_external.ForeColor = Color.White;
        }

        private void label_view_table_book_MouseEnter(object sender, EventArgs e)
        {
            label_view_table_book.ForeColor = Color.Green;
        }

        private void label_view_table_book_MouseLeave(object sender, EventArgs e)
        {
            label_view_table_book.ForeColor = Color.White;
        }

        private void label_upload_bookcover_MouseEnter(object sender, EventArgs e)
        {
            label_upload_bookcover.ForeColor = Color.Green;
        }

        private void label_upload_bookcover_MouseLeave(object sender, EventArgs e)
        {
            label_upload_bookcover.ForeColor = Color.White;
        }

        private void label_reset_MouseEnter(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.Green;
        }

        private void label_reset_MouseLeave(object sender, EventArgs e)
        {
            label_reset.ForeColor = Color.White;
        }

        private void label_confirm_MouseEnter(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.Green;
        }

        private void label_confirm_MouseLeave(object sender, EventArgs e)
        {
            label_confirm.ForeColor = Color.White;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_upload_bookcover_Click(object sender, EventArgs e)
        {
            openFileDialog_bookcover.ShowDialog();
        }
    }
}
