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
    public partial class Frm_Borrow : Form
    {
        public Frm_Borrow()
        {
            InitializeComponent();
        }

        private void label_add_new_reader_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_add_new_reader);
        }

        private void label_add_new_reader_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_add_new_reader);
        }

        private void label_add_new_book_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_add_new_book);
        }

        private void label_add_new_book_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_add_new_book);
        }

        private void label_view_table_readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_view_table_readers);
        }

        private void label_view_table_readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_view_table_readers);
        }

        private void label_view_table_books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_view_table_books);
        }

        private void label_view_table_books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_view_table_books);
        }

        private void label_search_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_search);
        }

        private void label_search_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_search);
        }

        private void label_reset_research_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_reset_research);
        }

        private void label_reset_research_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_reset_research);
        }

        private void label_next_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_next);
        }

        private void label_next_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_next);
        }

        private void label_back_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_back);
        }

        private void label_back_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_back);
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(label_close);
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(label_close);
        }
    }
}
