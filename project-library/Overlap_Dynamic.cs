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
    public partial class Overlap_Dynamic : Form
    {
        private UserControlList list = new UserControlList();

        public Overlap_Dynamic()
        {
            InitializeComponent();
            list.AddControl(new CustomUserControl("Panel_Home", new Panel_Form_Main()));
            list.AddControl(new CustomUserControl("Panel_Borrow_Return", new Panel_Form_Borrow_Return()));
            list.AddControl(new CustomUserControl("Panel_Books", new Panel_Form_Books()));
            list.AddControl(new CustomUserControl("Panel_Category", new Panel_Form_Category()));
            list.AddControl(new CustomUserControl("Panel_Readers", new Panel_Form_Readers()));
        }

        private void SetUserControlOnPanel(OverlapUserControl overlap)
        {
            Panel_Main.Controls.Clear();
            if (!Panel_Main.Controls.Contains(overlap))
            {
                Panel_Main.Controls.Add(overlap);
                overlap.Dock = DockStyle.Fill;
                overlap.BringToFront();
            }
            else
            {
                overlap.BringToFront();
            }
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(list["Panel_Home"]);
        }

        private void Button_Borrow_Return_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(list["Panel_Borrow_Return"]);
        }

        private void Button_Books_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(list["Panel_Books"]);
        }

        private void Button_Category_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(list["Panel_Category"]);
        }

        private void Button_Readers_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(list["Panel_Readers"]);
        }
    }
}
