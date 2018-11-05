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
    public partial class Frm_Table : Form
    {
        public Frm_Table()
        {
            InitializeComponent();
        }

        public Frm_Table(String title)
        {
            InitializeComponent();
            label_title.Text = title;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_delete_MouseEnter(object sender, EventArgs e)
        {
            label_delete.ForeColor = Color.Green;
        }

        private void label_delete_MouseLeave(object sender, EventArgs e)
        {
            label_delete.ForeColor = Color.White;
        }

        private void label_update_MouseEnter(object sender, EventArgs e)
        {
            label_update.ForeColor = Color.Green;
        }

        private void label_update_MouseLeave(object sender, EventArgs e)
        {
            label_update.ForeColor = Color.White;
        }

        private void label_insert_MouseEnter(object sender, EventArgs e)
        {
            label_insert.ForeColor = Color.Green;
        }

        private void label_insert_MouseLeave(object sender, EventArgs e)
        {
            label_insert.ForeColor = Color.White;
        }

        private void label_view_MouseEnter(object sender, EventArgs e)
        {
            label_view.ForeColor = Color.Green;
        }

        private void label_view_MouseLeave(object sender, EventArgs e)
        {
            label_view.ForeColor = Color.White;
        }

        private void label_refresh_MouseEnter(object sender, EventArgs e)
        {
            label_refresh.ForeColor = Color.Green;
        }

        private void label_refresh_MouseLeave(object sender, EventArgs e)
        {
            label_refresh.ForeColor = Color.White;
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
