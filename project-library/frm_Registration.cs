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
    public partial class frm_Registration : MetroFramework.Forms.MetroForm
    {
        public frm_Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frm_Registration frmRegistration = new frm_Registration();
            frmRegistration.Close();
            frmMain.Show();
            
        }

        private void btnBrowsePP_Click(object sender, EventArgs e)
        {
            dlgImage.Filter = "Image File|*.bmp;*.jpg;*.ico;*.png|All File|*.*";
            dlgImage.ShowDialog();
            dlgImage.FileName = dlgImage.FileName;
            //pcbPhoto.Image = System.Drawing.Image.FromFile(ImageFilter.FileName);
            pctPP.ImageLocation = dlgImage.FileName;
            pctPP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBrowseID_Click(object sender, EventArgs e)
        {
            dlgImage.Filter = "Image File|*.bmp;*.jpg;*.ico;*.png|All File|*.*";
            dlgImage.ShowDialog();
            dlgImage.FileName = dlgImage.FileName;
            //pcbPhoto.Image = System.Drawing.Image.FromFile(ImageFilter.FileName);
            pctID.ImageLocation = dlgImage.FileName;
            pctID.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnTakesPP_Click(object sender, EventArgs e)
        {

        }

        private void btnTakesID_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtContactNumber.Text = "";
            txtDateofBirth.Text = "";
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtOccupation.Text = "";
            cboGender.Text = "";
            txtOrganization.Text = "";
            pctID.ImageLocation = "";
            pctPP.ImageLocation = "";
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frm_Book frmBooks = new frm_Book();
            frmBooks.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the form, bitch!!!");
        }

        private void btnBookTraffic_Click(object sender, EventArgs e)
        {
            frm_BooksTraffic frmBooksTraffic = new frm_BooksTraffic();
            frmBooksTraffic.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frm_Borrow frmBorrow = new frm_Borrow();
            frmBorrow.Show();
        }
    }
}
