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
    public partial class Panel_Form_Readers : Form
    {
        public Panel_Form_Readers()
        {
            InitializeComponent();
        }

        private void btn_insert_reader_Click(object sender, EventArgs e)
        {
            Frm_Insert_Reader frm_insert_reader = new Frm_Insert_Reader();
            frm_insert_reader.Show();
        }

        private void btn_find_reader_Click(object sender, EventArgs e)
        {
            Frm_Search frm_search = new Frm_Search();
            frm_search.Show();
        }
    }
}
