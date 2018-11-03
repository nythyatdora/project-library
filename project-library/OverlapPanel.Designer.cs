namespace project_library
{
    partial class OverlapPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlapPanel));
            this.button_home = new System.Windows.Forms.Button();
            this.button_books = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.picbox_profile = new System.Windows.Forms.PictureBox();
            this.label_email_address = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_report = new System.Windows.Forms.Button();
            this.button_myprofile = new System.Windows.Forms.Button();
            this.button_readers = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_borrow_return = new System.Windows.Forms.Button();
            this.panel_books = new System.Windows.Forms.Panel();
            this.btn_find_book = new System.Windows.Forms.Button();
            this.panel_books_picbox_profile = new System.Windows.Forms.PictureBox();
            this.panel_books_label_email_address = new System.Windows.Forms.Label();
            this.panel_books_label_username = new System.Windows.Forms.Label();
            this.btn_insert_book = new System.Windows.Forms.Button();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).BeginInit();
            this.panel_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_books_picbox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(12, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(131, 39);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "HOME";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_books
            // 
            this.button_books.Location = new System.Drawing.Point(12, 57);
            this.button_books.Name = "button_books";
            this.button_books.Size = new System.Drawing.Size(131, 39);
            this.button_books.TabIndex = 1;
            this.button_books.Text = "BOOKS";
            this.button_books.UseVisualStyleBackColor = true;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // panel_home
            // 
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_home.Controls.Add(this.picbox_profile);
            this.panel_home.Controls.Add(this.label_email_address);
            this.panel_home.Controls.Add(this.label_username);
            this.panel_home.Controls.Add(this.button_report);
            this.panel_home.Controls.Add(this.button_myprofile);
            this.panel_home.Controls.Add(this.button_readers);
            this.panel_home.Controls.Add(this.button_category);
            this.panel_home.Controls.Add(this.button1);
            this.panel_home.Controls.Add(this.button_borrow_return);
            this.panel_home.Location = new System.Drawing.Point(149, 12);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(852, 579);
            this.panel_home.TabIndex = 13;
            // 
            // picbox_profile
            // 
            this.picbox_profile.BackColor = System.Drawing.Color.Transparent;
            this.picbox_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_profile.Location = new System.Drawing.Point(764, 21);
            this.picbox_profile.Name = "picbox_profile";
            this.picbox_profile.Size = new System.Drawing.Size(63, 65);
            this.picbox_profile.TabIndex = 14;
            this.picbox_profile.TabStop = false;
            // 
            // label_email_address
            // 
            this.label_email_address.AutoSize = true;
            this.label_email_address.BackColor = System.Drawing.Color.Transparent;
            this.label_email_address.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_address.ForeColor = System.Drawing.Color.White;
            this.label_email_address.Location = new System.Drawing.Point(599, 53);
            this.label_email_address.Name = "label_email_address";
            this.label_email_address.Size = new System.Drawing.Size(158, 19);
            this.label_email_address.TabIndex = 13;
            this.label_email_address.Text = "email@address.com";
            this.label_email_address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(674, 34);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(83, 19);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_report
            // 
            this.button_report.BackColor = System.Drawing.Color.Transparent;
            this.button_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_report.FlatAppearance.BorderSize = 0;
            this.button_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.button_report.ForeColor = System.Drawing.Color.Transparent;
            this.button_report.Image = ((System.Drawing.Image)(resources.GetObject("button_report.Image")));
            this.button_report.Location = new System.Drawing.Point(577, 357);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(253, 155);
            this.button_report.TabIndex = 5;
            this.button_report.Text = "REPORT";
            this.button_report.UseVisualStyleBackColor = false;
            // 
            // button_myprofile
            // 
            this.button_myprofile.BackColor = System.Drawing.Color.Transparent;
            this.button_myprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_myprofile.FlatAppearance.BorderSize = 0;
            this.button_myprofile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_myprofile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_myprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_myprofile.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.button_myprofile.ForeColor = System.Drawing.Color.Transparent;
            this.button_myprofile.Image = ((System.Drawing.Image)(resources.GetObject("button_myprofile.Image")));
            this.button_myprofile.Location = new System.Drawing.Point(298, 357);
            this.button_myprofile.Name = "button_myprofile";
            this.button_myprofile.Size = new System.Drawing.Size(253, 155);
            this.button_myprofile.TabIndex = 4;
            this.button_myprofile.Text = "MY PROFILE";
            this.button_myprofile.UseVisualStyleBackColor = false;
            // 
            // button_readers
            // 
            this.button_readers.BackColor = System.Drawing.Color.Transparent;
            this.button_readers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_readers.FlatAppearance.BorderSize = 0;
            this.button_readers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_readers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_readers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_readers.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.button_readers.ForeColor = System.Drawing.Color.Transparent;
            this.button_readers.Image = ((System.Drawing.Image)(resources.GetObject("button_readers.Image")));
            this.button_readers.Location = new System.Drawing.Point(20, 357);
            this.button_readers.Name = "button_readers";
            this.button_readers.Size = new System.Drawing.Size(253, 155);
            this.button_readers.TabIndex = 3;
            this.button_readers.Text = "READERS";
            this.button_readers.UseVisualStyleBackColor = false;
            // 
            // button_category
            // 
            this.button_category.BackColor = System.Drawing.Color.Transparent;
            this.button_category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.button_category.ForeColor = System.Drawing.Color.Transparent;
            this.button_category.Image = ((System.Drawing.Image)(resources.GetObject("button_category.Image")));
            this.button_category.Location = new System.Drawing.Point(577, 178);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(253, 155);
            this.button_category.TabIndex = 2;
            this.button_category.Text = "CATEGORY";
            this.button_category.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(298, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 155);
            this.button1.TabIndex = 1;
            this.button1.Text = "BOOKS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_borrow_return
            // 
            this.button_borrow_return.BackColor = System.Drawing.Color.Transparent;
            this.button_borrow_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_borrow_return.FlatAppearance.BorderSize = 0;
            this.button_borrow_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_borrow_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_borrow_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrow_return.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrow_return.ForeColor = System.Drawing.Color.Transparent;
            this.button_borrow_return.Image = ((System.Drawing.Image)(resources.GetObject("button_borrow_return.Image")));
            this.button_borrow_return.Location = new System.Drawing.Point(20, 178);
            this.button_borrow_return.Name = "button_borrow_return";
            this.button_borrow_return.Size = new System.Drawing.Size(253, 155);
            this.button_borrow_return.TabIndex = 0;
            this.button_borrow_return.Text = "BORROW/RETURN";
            this.button_borrow_return.UseVisualStyleBackColor = false;
            // 
            // panel_books
            // 
            this.panel_books.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_books.BackgroundImage")));
            this.panel_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_books.Controls.Add(this.btn_find_book);
            this.panel_books.Controls.Add(this.panel_books_picbox_profile);
            this.panel_books.Controls.Add(this.panel_books_label_email_address);
            this.panel_books.Controls.Add(this.panel_books_label_username);
            this.panel_books.Controls.Add(this.btn_insert_book);
            this.panel_books.Location = new System.Drawing.Point(149, 12);
            this.panel_books.Name = "panel_books";
            this.panel_books.Size = new System.Drawing.Size(852, 579);
            this.panel_books.TabIndex = 14;
            // 
            // btn_find_book
            // 
            this.btn_find_book.BackColor = System.Drawing.Color.Transparent;
            this.btn_find_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_find_book.FlatAppearance.BorderSize = 0;
            this.btn_find_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_find_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_find_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_book.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_book.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_find_book.Image")));
            this.btn_find_book.Location = new System.Drawing.Point(474, 183);
            this.btn_find_book.Name = "btn_find_book";
            this.btn_find_book.Size = new System.Drawing.Size(283, 285);
            this.btn_find_book.TabIndex = 15;
            this.btn_find_book.Text = "FIND BOOK";
            this.btn_find_book.UseVisualStyleBackColor = false;
            // 
            // panel_books_picbox_profile
            // 
            this.panel_books_picbox_profile.BackColor = System.Drawing.Color.Transparent;
            this.panel_books_picbox_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_books_picbox_profile.Location = new System.Drawing.Point(764, 21);
            this.panel_books_picbox_profile.Name = "panel_books_picbox_profile";
            this.panel_books_picbox_profile.Size = new System.Drawing.Size(63, 65);
            this.panel_books_picbox_profile.TabIndex = 14;
            this.panel_books_picbox_profile.TabStop = false;
            // 
            // panel_books_label_email_address
            // 
            this.panel_books_label_email_address.AutoSize = true;
            this.panel_books_label_email_address.BackColor = System.Drawing.Color.Transparent;
            this.panel_books_label_email_address.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_books_label_email_address.ForeColor = System.Drawing.Color.White;
            this.panel_books_label_email_address.Location = new System.Drawing.Point(599, 53);
            this.panel_books_label_email_address.Name = "panel_books_label_email_address";
            this.panel_books_label_email_address.Size = new System.Drawing.Size(158, 19);
            this.panel_books_label_email_address.TabIndex = 13;
            this.panel_books_label_email_address.Text = "email@address.com";
            this.panel_books_label_email_address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel_books_label_username
            // 
            this.panel_books_label_username.AutoSize = true;
            this.panel_books_label_username.BackColor = System.Drawing.Color.Transparent;
            this.panel_books_label_username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_books_label_username.ForeColor = System.Drawing.Color.White;
            this.panel_books_label_username.Location = new System.Drawing.Point(674, 34);
            this.panel_books_label_username.Name = "panel_books_label_username";
            this.panel_books_label_username.Size = new System.Drawing.Size(83, 19);
            this.panel_books_label_username.TabIndex = 12;
            this.panel_books_label_username.Text = "username";
            this.panel_books_label_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_insert_book
            // 
            this.btn_insert_book.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_insert_book.FlatAppearance.BorderSize = 0;
            this.btn_insert_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_insert_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_insert_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert_book.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_book.ForeColor = System.Drawing.Color.Transparent;
            this.btn_insert_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert_book.Image")));
            this.btn_insert_book.Location = new System.Drawing.Point(81, 183);
            this.btn_insert_book.Name = "btn_insert_book";
            this.btn_insert_book.Size = new System.Drawing.Size(283, 285);
            this.btn_insert_book.TabIndex = 0;
            this.btn_insert_book.Text = "INPUT/INSERT\r\nNEW BOOK";
            this.btn_insert_book.UseVisualStyleBackColor = false;
            // 
            // OverlapPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.button_books);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel_books);
            this.Name = "OverlapPanel";
            this.Text = "OverlapPanel";
            this.Load += new System.EventHandler(this.OverlapPanel_Load);
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).EndInit();
            this.panel_books.ResumeLayout(false);
            this.panel_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_books_picbox_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_books;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.PictureBox picbox_profile;
        private System.Windows.Forms.Label label_email_address;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_report;
        private System.Windows.Forms.Button button_myprofile;
        private System.Windows.Forms.Button button_readers;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_borrow_return;
        private System.Windows.Forms.Panel panel_books;
        private System.Windows.Forms.Button btn_find_book;
        private System.Windows.Forms.PictureBox panel_books_picbox_profile;
        private System.Windows.Forms.Label panel_books_label_email_address;
        private System.Windows.Forms.Label panel_books_label_username;
        private System.Windows.Forms.Button btn_insert_book;
    }
}