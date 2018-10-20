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
    public partial class frm_BooksLocation : MetroFramework.Forms.MetroForm
    {
        public frm_BooksLocation()
        {
            InitializeComponent();
        }

        private void frm_BooksLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frm_Book frmBook = new frm_Book();
            frmBook.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frm_Registration frmRegistration = new frm_Registration();
            frmRegistration.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frmMain.Show();
        }

        private void btnBookTraffic_Click(object sender, EventArgs e)
        {
            frm_BooksTraffic frmBooksTraffic = new frm_BooksTraffic();
            frmBooksTraffic.Show();
        }

        private void btnBookLocate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the form, bitch!!!");
        }

        private void btnBorrow1_Click(object sender, EventArgs e)
        {
            frm_Borrow frmBorrow = new frm_Borrow();
            frmBorrow.Show();
        }
    }
}
