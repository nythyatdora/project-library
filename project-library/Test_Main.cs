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
    public partial class Test_Main : Form
    {
        List<Panel> panel_body = new List<Panel>();

        private void setPanelBody()
        {
            panel_body.Add(panel_main);
            panel_body.Add(panel_borrow_return);
            panel_body.Add(panel_books);
            panel_body.Add(panel_category);
            panel_body.Add(panel_readers);
        }

        public Test_Main()
        {
            InitializeComponent();
            setPanelBody();
            panel_body[0].BringToFront();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_home_Click(object sender, EventArgs e)
        {
            panel_body[0].BringToFront();
        }

        private void label_borrow_return_Click(object sender, EventArgs e)
        {
            panel_body[1].BringToFront();
        }

        private void label_books_Click(object sender, EventArgs e)
        {
            panel_body[2].BringToFront();
        }

        private void label_category_Click(object sender, EventArgs e)
        {
            panel_body[3].BringToFront();
        }

        private void label_readers_Click(object sender, EventArgs e)
        {
            panel_body[4].BringToFront();
        }

        private void label_myprofile_Click(object sender, EventArgs e)
        {

        }

        private void label_report_Click(object sender, EventArgs e)
        {

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

        private void btn_science_fiction_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Science Fiction");
            frm_table.Show();
        }

        private void btn_drama_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Drama");
            frm_table.Show();
        }

        private void btn_mystery_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Mystery");
            frm_table.Show();
        }

        private void btn_comics_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Comics");
            frm_table.Show();
        }

        private void btn_math_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Maths");
            frm_table.Show();
        }

        private void btn_horror_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Horror");
            frm_table.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("History");
            frm_table.Show();
        }

        private void btn_fantasy_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Fantasy");
            frm_table.Show();
        }

        private void btn_adventure_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Adventure");
            frm_table.Show();
        }

        private void btn_science_Click(object sender, EventArgs e)
        {
            Frm_Table frm_table = new Frm_Table("Science");
            frm_table.Show();
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

        private void panel_main_button_borrow_return_Click(object sender, EventArgs e)
        {
            panel_body[1].BringToFront();
        }

        private void panel_main_button_books_Click(object sender, EventArgs e)
        {
            panel_body[2].BringToFront();
        }

        private void panel_main_button_category_Click(object sender, EventArgs e)
        {
            panel_body[3].BringToFront();
        }

        private void panel_main_button_readers_Click(object sender, EventArgs e)
        {
            panel_body[4].BringToFront();
        }
    }
}
