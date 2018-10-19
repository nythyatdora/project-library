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
    public partial class frm_main : MetroFramework.Forms.MetroForm
    {
        public frm_main()
        {
            InitializeComponent();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            

        }

        
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frmMain.Close();
            frm_Registration frmRegistration = new frm_Registration();
            frmRegistration.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frmMain.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frm_main frmMain = new frm_main();
            frmMain.Close();
            frm_Book frmBook = new frm_Book();
            frmBook.Show();
        }
    }
}
