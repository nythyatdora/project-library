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
    public partial class Panel_Form_Books : Form
    {
        public Panel_Form_Books()
        {
            InitializeComponent();
        }

        private void btn_insert_book_Click(object sender, EventArgs e)
        {
            Frm_Insert_Book frm_insert_book = new Frm_Insert_Book();
            frm_insert_book.Show();
        }

        private void btn_find_book_Click(object sender, EventArgs e)
        {
            Frm_Search frm_search = new Frm_Search();
            frm_search.Show();
        }
    }
}
