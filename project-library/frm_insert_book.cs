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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_view_table_book_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table();
            frm_table.Show();
        }
    }
}
