using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_library.Class;

namespace project_library
{
    public partial class Form_Main : Form
    {
        private UserControlList List_Panels = new UserControlList();

        public Form_Main()
        {
            InitializeComponent();

            List_Panels.AddControl(new CustomUserControl("Panel_Home", new Panel_Home()));
            List_Panels.AddControl(new CustomUserControl("Panel_Borrow_Return", new Panel_Borrow_Return()));
            List_Panels.AddControl(new CustomUserControl("Panel_Books", new Panel_Books()));
            List_Panels.AddControl(new CustomUserControl("Panel_Category", new Panel_Category()));
            List_Panels.AddControl(new CustomUserControl("Panel_Readers", new Panel_Readers()));
            List_Panels.AddControl(new CustomUserControl("Panel_Myprofile", new Panel_MyProfile_One()));
        }

        private void Label_Dropmenu_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Dropmenu);
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

        private void Label_Dropmenu_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Dropmenu);
        }

        private void Label_Home_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Home);
        }

        private void Label_Home_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Home);
        }

        private void Label_Borrow_Return_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Borrow_Return);
        }

        private void Label_Borrow_Return_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Borrow_Return);
        }

        private void Label_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Books);
        }

        private void Label_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Books);
        }

        private void Label_Category_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Category);
        }

        private void Label_Category_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Category);
        }

        private void Label_Readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Readers);
        }

        private void Label_Readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Readers);
        }

        private void Label_Membership_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Membership);
        }

        private void Label_Membership_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Membership);
        }

        private void Label_Myprofile_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Myprofile);
        }

        private void Label_Myprofile_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Myprofile);
        }

        private void Label_Report_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Report);
        }

        private void Label_Report_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Report);
        }

        private void Label_Exit_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Exit);
        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Exit);
        }

        private void Label_Dropmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label_Dropmenu.ContextMenuStrip = ContextMenuStrip_Main;
                Label_Dropmenu.ContextMenuStrip.Show(Label_Dropmenu,5,25);
            }
        }

        private void Label_Home_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Home"]);
        }

        private void Label_Borrow_Return_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Borrow_Return"]);
        }

        private void Label_Books_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Books"]);
        }

        private void Label_Category_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Category"]);
        }

        private void Label_Readers_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Readers"]);
        }

        private void Label_Membership_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Membership"]);
        }

        private void Label_Myprofile_Click(object sender, EventArgs e)
        {
            SetUserControlOnPanel(List_Panels["Panel_Myprofile"]);
        }

        private void Label_Report_Click(object sender, EventArgs e)
        {
        }
    }
}
