namespace project_library
{
    partial class Frm_Borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Borrow));
            this.panel_head = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_back = new System.Windows.Forms.Label();
            this.datagrid_table = new System.Windows.Forms.DataGridView();
            this.label_view_table_books = new System.Windows.Forms.Label();
            this.label_view_table_readers = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_next = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.label_reset_research = new System.Windows.Forms.Label();
            this.cbo_filter = new System.Windows.Forms.ComboBox();
            this.txt_searchby = new System.Windows.Forms.TextBox();
            this.label_filter = new System.Windows.Forms.Label();
            this.label_book_title = new System.Windows.Forms.Label();
            this.label_add_new_book = new System.Windows.Forms.Label();
            this.label_add_new_reader = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_head.BackgroundImage")));
            this.panel_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(900, 6);
            this.panel_head.TabIndex = 2;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_body.Controls.Add(this.label_back);
            this.panel_body.Controls.Add(this.datagrid_table);
            this.panel_body.Controls.Add(this.label_view_table_books);
            this.panel_body.Controls.Add(this.label_view_table_readers);
            this.panel_body.Controls.Add(this.label_close);
            this.panel_body.Controls.Add(this.label_next);
            this.panel_body.Controls.Add(this.label_search);
            this.panel_body.Controls.Add(this.label_reset_research);
            this.panel_body.Controls.Add(this.cbo_filter);
            this.panel_body.Controls.Add(this.txt_searchby);
            this.panel_body.Controls.Add(this.label_filter);
            this.panel_body.Controls.Add(this.label_book_title);
            this.panel_body.Controls.Add(this.label_add_new_book);
            this.panel_body.Controls.Add(this.label_add_new_reader);
            this.panel_body.Location = new System.Drawing.Point(0, 6);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(900, 685);
            this.panel_body.TabIndex = 3;
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.BackColor = System.Drawing.Color.Transparent;
            this.label_back.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.ForeColor = System.Drawing.Color.White;
            this.label_back.Location = new System.Drawing.Point(33, 646);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(58, 23);
            this.label_back.TabIndex = 80;
            this.label_back.Text = "BACK";
            this.label_back.MouseEnter += new System.EventHandler(this.label_back_MouseEnter);
            this.label_back.MouseLeave += new System.EventHandler(this.label_back_MouseLeave);
            // 
            // datagrid_table
            // 
            this.datagrid_table.AllowUserToAddRows = false;
            this.datagrid_table.AllowUserToDeleteRows = false;
            this.datagrid_table.AllowUserToResizeColumns = false;
            this.datagrid_table.AllowUserToResizeRows = false;
            this.datagrid_table.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_table.ColumnHeadersHeight = 30;
            this.datagrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_table.Location = new System.Drawing.Point(37, 315);
            this.datagrid_table.MultiSelect = false;
            this.datagrid_table.Name = "datagrid_table";
            this.datagrid_table.RowHeadersVisible = false;
            this.datagrid_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_table.Size = new System.Drawing.Size(828, 315);
            this.datagrid_table.TabIndex = 79;
            // 
            // label_view_table_books
            // 
            this.label_view_table_books.AutoSize = true;
            this.label_view_table_books.BackColor = System.Drawing.Color.Transparent;
            this.label_view_table_books.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_view_table_books.ForeColor = System.Drawing.Color.White;
            this.label_view_table_books.Location = new System.Drawing.Point(630, 91);
            this.label_view_table_books.Name = "label_view_table_books";
            this.label_view_table_books.Size = new System.Drawing.Size(105, 46);
            this.label_view_table_books.TabIndex = 78;
            this.label_view_table_books.Text = "view\r\ntable books";
            this.label_view_table_books.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_view_table_books.MouseEnter += new System.EventHandler(this.label_view_table_books_MouseEnter);
            this.label_view_table_books.MouseLeave += new System.EventHandler(this.label_view_table_books_MouseLeave);
            // 
            // label_view_table_readers
            // 
            this.label_view_table_readers.AutoSize = true;
            this.label_view_table_readers.BackColor = System.Drawing.Color.Transparent;
            this.label_view_table_readers.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_view_table_readers.ForeColor = System.Drawing.Color.White;
            this.label_view_table_readers.Location = new System.Drawing.Point(614, 31);
            this.label_view_table_readers.Name = "label_view_table_readers";
            this.label_view_table_readers.Size = new System.Drawing.Size(121, 46);
            this.label_view_table_readers.TabIndex = 77;
            this.label_view_table_readers.Text = "view\r\ntable readers";
            this.label_view_table_readers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_view_table_readers.MouseEnter += new System.EventHandler(this.label_view_table_readers_MouseEnter);
            this.label_view_table_readers.MouseLeave += new System.EventHandler(this.label_view_table_readers_MouseLeave);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(23, 18);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(55, 23);
            this.label_close.TabIndex = 76;
            this.label_close.Text = "close";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_next
            // 
            this.label_next.AutoSize = true;
            this.label_next.BackColor = System.Drawing.Color.Transparent;
            this.label_next.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_next.ForeColor = System.Drawing.Color.White;
            this.label_next.Location = new System.Drawing.Point(811, 646);
            this.label_next.Name = "label_next";
            this.label_next.Size = new System.Drawing.Size(54, 23);
            this.label_next.TabIndex = 75;
            this.label_next.Text = "NEXT";
            this.label_next.MouseEnter += new System.EventHandler(this.label_next_MouseEnter);
            this.label_next.MouseLeave += new System.EventHandler(this.label_next_MouseLeave);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(791, 273);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(82, 23);
            this.label_search.TabIndex = 55;
            this.label_search.Text = "SEARCH";
            this.label_search.MouseEnter += new System.EventHandler(this.label_search_MouseEnter);
            this.label_search.MouseLeave += new System.EventHandler(this.label_search_MouseLeave);
            // 
            // label_reset_research
            // 
            this.label_reset_research.AutoSize = true;
            this.label_reset_research.BackColor = System.Drawing.Color.Transparent;
            this.label_reset_research.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reset_research.ForeColor = System.Drawing.Color.White;
            this.label_reset_research.Location = new System.Drawing.Point(33, 273);
            this.label_reset_research.Name = "label_reset_research";
            this.label_reset_research.Size = new System.Drawing.Size(140, 23);
            this.label_reset_research.TabIndex = 54;
            this.label_reset_research.Text = "RESET SEARCH";
            this.label_reset_research.MouseEnter += new System.EventHandler(this.label_reset_research_MouseEnter);
            this.label_reset_research.MouseLeave += new System.EventHandler(this.label_reset_research_MouseLeave);
            // 
            // cbo_filter
            // 
            this.cbo_filter.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.cbo_filter.FormattingEnabled = true;
            this.cbo_filter.Location = new System.Drawing.Point(650, 217);
            this.cbo_filter.Name = "cbo_filter";
            this.cbo_filter.Size = new System.Drawing.Size(215, 33);
            this.cbo_filter.TabIndex = 53;
            // 
            // txt_searchby
            // 
            this.txt_searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchby.Location = new System.Drawing.Point(37, 217);
            this.txt_searchby.Name = "txt_searchby";
            this.txt_searchby.Size = new System.Drawing.Size(585, 33);
            this.txt_searchby.TabIndex = 52;
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.BackColor = System.Drawing.Color.Transparent;
            this.label_filter.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filter.ForeColor = System.Drawing.Color.White;
            this.label_filter.Location = new System.Drawing.Point(800, 185);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(65, 29);
            this.label_filter.TabIndex = 51;
            this.label_filter.Text = "filter";
            // 
            // label_book_title
            // 
            this.label_book_title.AutoSize = true;
            this.label_book_title.BackColor = System.Drawing.Color.Transparent;
            this.label_book_title.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_book_title.ForeColor = System.Drawing.Color.White;
            this.label_book_title.Location = new System.Drawing.Point(32, 185);
            this.label_book_title.Name = "label_book_title";
            this.label_book_title.Size = new System.Drawing.Size(118, 29);
            this.label_book_title.TabIndex = 50;
            this.label_book_title.Text = "Search by";
            // 
            // label_add_new_book
            // 
            this.label_add_new_book.AutoSize = true;
            this.label_add_new_book.BackColor = System.Drawing.Color.Transparent;
            this.label_add_new_book.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_new_book.ForeColor = System.Drawing.Color.White;
            this.label_add_new_book.Location = new System.Drawing.Point(776, 91);
            this.label_add_new_book.Name = "label_add_new_book";
            this.label_add_new_book.Size = new System.Drawing.Size(89, 46);
            this.label_add_new_book.TabIndex = 3;
            this.label_add_new_book.Text = "add\r\nnew book";
            this.label_add_new_book.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_add_new_book.MouseEnter += new System.EventHandler(this.label_add_new_book_MouseEnter);
            this.label_add_new_book.MouseLeave += new System.EventHandler(this.label_add_new_book_MouseLeave);
            // 
            // label_add_new_reader
            // 
            this.label_add_new_reader.AutoSize = true;
            this.label_add_new_reader.BackColor = System.Drawing.Color.Transparent;
            this.label_add_new_reader.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_new_reader.ForeColor = System.Drawing.Color.White;
            this.label_add_new_reader.Location = new System.Drawing.Point(760, 31);
            this.label_add_new_reader.Name = "label_add_new_reader";
            this.label_add_new_reader.Size = new System.Drawing.Size(105, 46);
            this.label_add_new_reader.TabIndex = 2;
            this.label_add_new_reader.Text = "add\r\nnew reader";
            this.label_add_new_reader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_add_new_reader.MouseEnter += new System.EventHandler(this.label_add_new_reader_MouseEnter);
            this.label_add_new_reader.MouseLeave += new System.EventHandler(this.label_add_new_reader_MouseLeave);
            // 
            // Frm_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 691);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Borrow";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_next;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_reset_research;
        private System.Windows.Forms.ComboBox cbo_filter;
        private System.Windows.Forms.TextBox txt_searchby;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.Label label_book_title;
        private System.Windows.Forms.Label label_add_new_book;
        private System.Windows.Forms.Label label_add_new_reader;
        private System.Windows.Forms.Label label_view_table_books;
        private System.Windows.Forms.Label label_view_table_readers;
        private System.Windows.Forms.DataGridView datagrid_table;
        private System.Windows.Forms.Label label_back;
    }
}