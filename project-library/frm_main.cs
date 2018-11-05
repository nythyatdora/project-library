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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setColorLabelGreen(Label label)
        {
            label.ForeColor = Color.Green;
        }

        private void setColorLabelWhite(Label label)
        {
            label.ForeColor = Color.White;
        }

        private void setImageButtonEnter_Small(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Small;
        }

        private void setImageButtonLeave_Small(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Small;
        }


        private void setImageButtonEnter_Big(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Big;
        }

        private void setImageButtonLeave_Big(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Big;
        }

        private void label_dropmenu_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_dropmenu);
        }

        private void label_dropmenu_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_dropmenu);
        }

        private void label_home_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_home);
        }

        private void label_home_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_home);
        }

        private void label_borrow_return_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_borrow_return);
        }

        private void label_borrow_return_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_borrow_return);
        }

        private void label_books_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_books);
        }

        private void label_books_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_books);
        }

        private void label_category_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_category);
        }

        private void label_category_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_category);
        }

        private void label_readers_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_readers);
        }

        private void label_readers_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_readers);
        }

        private void label_membership_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_membership);
        }

        private void label_membership_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_membership);
        }

        private void label_myprofile_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_myprofile);
        }

        private void label_myprofile_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_myprofile);
        }

        private void label_report_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_report);
        }

        private void label_report_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_report);
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            setColorLabelGreen(label_exit);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            setColorLabelWhite(label_exit);
        }

        private void label_dropmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label_dropmenu.ContextMenuStrip = contextMenuStrip;
                label_dropmenu.ContextMenuStrip.Show(label_dropmenu,5,25);
            }
        }

        private void panel_main_button_borrow_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Small(panel_main_button_borrow);
        }

        private void panel_main_button_borrow_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Small(panel_main_button_borrow);
        }

        private void panel_main_button_return_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Small(panel_main_button_return);
        }

        private void panel_main_button_return_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Small(panel_main_button_return);
        }

        private void panel_main_button_books_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Big(panel_main_button_books);
        }

        private void panel_main_button_books_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Big(panel_main_button_books);
        }

        private void panel_main_button_category_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Big(panel_main_button_category);
        }

        private void panel_main_button_category_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Big(panel_main_button_category);
        }

        private void panel_main_button_readers_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Small(panel_main_button_readers);
        }

        private void panel_main_button_readers_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Small(panel_main_button_readers);
        }

        private void panel_main_button_membership_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Small(panel_main_button_membership);
        }

        private void panel_main_button_membership_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Small(panel_main_button_membership);
        }

        private void panel_main_button_myprofile_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Big(panel_main_button_myprofile);
        }

        private void panel_main_button_myprofile_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Big(panel_main_button_myprofile);
        }

        private void panel_main_button_report_MouseEnter(object sender, EventArgs e)
        {
            setImageButtonEnter_Big(panel_main_button_report);
        }

        private void panel_main_button_report_MouseLeave(object sender, EventArgs e)
        {
            setImageButtonLeave_Big(panel_main_button_report);
        }
    }
}
