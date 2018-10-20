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
    public partial class frm_Book : MetroFramework.Forms.MetroForm
    {
        public frm_Book()
        {
            InitializeComponent();
        }

        private void frm_Book_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frmMain.Show();
        }

        private void btnBrowseFP_Click(object sender, EventArgs e)
        {
            dlgImage.Filter = "Image File|*.bmp;*.jpg;*.ico;*.png|All File|*.*";
            dlgImage.ShowDialog();
            dlgImage.FileName = dlgImage.FileName;
            //pcbPhoto.Image = System.Drawing.Image.FromFile(ImageFilter.FileName);
            pctFP.ImageLocation = dlgImage.FileName;
            pctFP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnTakesFP_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseBP_Click(object sender, EventArgs e)
        {
            dlgImage.Filter = "Image File|*.bmp;*.jpg;*.ico;*.png|All File|*.*";
            dlgImage.ShowDialog();
            dlgImage.FileName = dlgImage.FileName;
            //pcbPhoto.Image = System.Drawing.Image.FromFile(ImageFilter.FileName);
            pctBP.ImageLocation = dlgImage.FileName;
            pctBP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnTakesBP_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtISBN.Text = "";
            txtPublishDate.Text = "";
            txtPublisher.Text = "";
            txtTitle.Text = "";
            txtWriter.Text = "";
            cboLocatation.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnOption_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frm_Registration frmRegistration = new frm_Registration();
            frmRegistration.Show();
        }

        private void btnBookLocate_Click(object sender, EventArgs e)
        {
            frm_BooksLocation frmBookLocation = new frm_BooksLocation();
            frmBookLocation.Show();
        }

        private void btnBookTraffic_Click(object sender, EventArgs e)
        {
            frm_BooksTraffic frmBooksTraffic = new frm_BooksTraffic();
            frmBooksTraffic.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the form, bitch!!!");
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frm_Borrow frmBorrow = new frm_Borrow();
            frmBorrow.Show();
        }
    }
}
