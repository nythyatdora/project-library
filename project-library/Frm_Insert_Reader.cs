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
    public partial class Frm_Insert_Reader : Form
    {
        public Frm_Insert_Reader()
        {
            InitializeComponent();
        }

        private void label_view_table_readers_Click(object sender, EventArgs e)
        {

        }

        private void label_view_table_readers_MouseEnter(object sender, EventArgs e)
        {
            label_view_table_readers.ForeColor = Color.Green;
        }

        private void label_view_table_readers_MouseLeave(object sender, EventArgs e)
        {
            label_view_table_readers.ForeColor = Color.White;
        }

        private void label_upload_picture_MouseEnter(object sender, EventArgs e)
        {
            label_upload_picture.ForeColor = Color.Green;
        }

        private void label_upload_picture_MouseLeave(object sender, EventArgs e)
        {
            label_upload_picture.ForeColor = Color.White;
        }

        private void label_upload_identification_MouseEnter(object sender, EventArgs e)
        {
            label_upload_identification.ForeColor = Color.Green;
        }

        private void label_upload_identification_MouseLeave(object sender, EventArgs e)
        {
            label_upload_identification.ForeColor = Color.White;
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

        private void label_upload_picture_Click(object sender, EventArgs e)
        {
            openFileDialog_ReaderPicture.ShowDialog();
        }

        private void label_upload_identification_Click(object sender, EventArgs e)
        {
            openFileDialog_IdentificationID.ShowDialog();
        }
    }
}
