﻿namespace project_library
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel_background = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_main_picbox_profile = new System.Windows.Forms.PictureBox();
            this.label_email_address = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_main_button_report = new System.Windows.Forms.Button();
            this.panel_main_button_myprofile = new System.Windows.Forms.Button();
            this.panel_main_button_readers = new System.Windows.Forms.Button();
            this.panel_main_button_category = new System.Windows.Forms.Button();
            this.panel_main_button_books = new System.Windows.Forms.Button();
            this.panel_main_button_borrow_return = new System.Windows.Forms.Button();
            this.label_dropmenu = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_report = new System.Windows.Forms.Label();
            this.label_myprofile = new System.Windows.Forms.Label();
            this.label_readers = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_books = new System.Windows.Forms.Label();
            this.label_borrow_return = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_background.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_main_picbox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_background.BackgroundImage")));
            this.panel_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_background.Controls.Add(this.btn_close);
            this.panel_background.Controls.Add(this.panel_main);
            this.panel_background.Controls.Add(this.label_dropmenu);
            this.panel_background.Controls.Add(this.label_date);
            this.panel_background.Controls.Add(this.label_position);
            this.panel_background.Controls.Add(this.label_report);
            this.panel_background.Controls.Add(this.label_myprofile);
            this.panel_background.Controls.Add(this.label_readers);
            this.panel_background.Controls.Add(this.label_category);
            this.panel_background.Controls.Add(this.label_books);
            this.panel_background.Controls.Add(this.label_borrow_return);
            this.panel_background.Controls.Add(this.label_home);
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(1100, 607);
            this.panel_background.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main.Controls.Add(this.panel_main_picbox_profile);
            this.panel_main.Controls.Add(this.label_email_address);
            this.panel_main.Controls.Add(this.label_username);
            this.panel_main.Controls.Add(this.panel_main_button_report);
            this.panel_main.Controls.Add(this.panel_main_button_myprofile);
            this.panel_main.Controls.Add(this.panel_main_button_readers);
            this.panel_main.Controls.Add(this.panel_main_button_category);
            this.panel_main.Controls.Add(this.panel_main_button_books);
            this.panel_main.Controls.Add(this.panel_main_button_borrow_return);
            this.panel_main.Location = new System.Drawing.Point(248, 6);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(852, 579);
            this.panel_main.TabIndex = 11;
            // 
            // panel_main_picbox_profile
            // 
            this.panel_main_picbox_profile.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_picbox_profile.Location = new System.Drawing.Point(764, 21);
            this.panel_main_picbox_profile.Name = "panel_main_picbox_profile";
            this.panel_main_picbox_profile.Size = new System.Drawing.Size(63, 65);
            this.panel_main_picbox_profile.TabIndex = 14;
            this.panel_main_picbox_profile.TabStop = false;
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
            // panel_main_button_report
            // 
            this.panel_main_button_report.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_report.FlatAppearance.BorderSize = 0;
            this.panel_main_button_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_report.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel_main_button_report.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_report.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_report.Image")));
            this.panel_main_button_report.Location = new System.Drawing.Point(577, 357);
            this.panel_main_button_report.Name = "panel_main_button_report";
            this.panel_main_button_report.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_report.TabIndex = 5;
            this.panel_main_button_report.Text = "REPORT";
            this.panel_main_button_report.UseVisualStyleBackColor = false;
            // 
            // panel_main_button_myprofile
            // 
            this.panel_main_button_myprofile.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_myprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_myprofile.FlatAppearance.BorderSize = 0;
            this.panel_main_button_myprofile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_myprofile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_myprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_myprofile.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel_main_button_myprofile.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_myprofile.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_myprofile.Image")));
            this.panel_main_button_myprofile.Location = new System.Drawing.Point(298, 357);
            this.panel_main_button_myprofile.Name = "panel_main_button_myprofile";
            this.panel_main_button_myprofile.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_myprofile.TabIndex = 4;
            this.panel_main_button_myprofile.Text = "MY PROFILE";
            this.panel_main_button_myprofile.UseVisualStyleBackColor = false;
            // 
            // panel_main_button_readers
            // 
            this.panel_main_button_readers.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_readers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_readers.FlatAppearance.BorderSize = 0;
            this.panel_main_button_readers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_readers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_readers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_readers.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel_main_button_readers.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_readers.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_readers.Image")));
            this.panel_main_button_readers.Location = new System.Drawing.Point(20, 357);
            this.panel_main_button_readers.Name = "panel_main_button_readers";
            this.panel_main_button_readers.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_readers.TabIndex = 3;
            this.panel_main_button_readers.Text = "READERS";
            this.panel_main_button_readers.UseVisualStyleBackColor = false;
            // 
            // panel_main_button_category
            // 
            this.panel_main_button_category.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_category.FlatAppearance.BorderSize = 0;
            this.panel_main_button_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_category.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel_main_button_category.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_category.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_category.Image")));
            this.panel_main_button_category.Location = new System.Drawing.Point(577, 178);
            this.panel_main_button_category.Name = "panel_main_button_category";
            this.panel_main_button_category.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_category.TabIndex = 2;
            this.panel_main_button_category.Text = "CATEGORY";
            this.panel_main_button_category.UseVisualStyleBackColor = false;
            // 
            // panel_main_button_books
            // 
            this.panel_main_button_books.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_books.FlatAppearance.BorderSize = 0;
            this.panel_main_button_books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_books.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel_main_button_books.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_books.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_books.Image")));
            this.panel_main_button_books.Location = new System.Drawing.Point(298, 178);
            this.panel_main_button_books.Name = "panel_main_button_books";
            this.panel_main_button_books.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_books.TabIndex = 1;
            this.panel_main_button_books.Text = "BOOKS";
            this.panel_main_button_books.UseVisualStyleBackColor = false;
            // 
            // panel_main_button_borrow_return
            // 
            this.panel_main_button_borrow_return.BackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_borrow_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main_button_borrow_return.FlatAppearance.BorderSize = 0;
            this.panel_main_button_borrow_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_borrow_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panel_main_button_borrow_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_main_button_borrow_return.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main_button_borrow_return.ForeColor = System.Drawing.Color.Transparent;
            this.panel_main_button_borrow_return.Image = ((System.Drawing.Image)(resources.GetObject("panel_main_button_borrow_return.Image")));
            this.panel_main_button_borrow_return.Location = new System.Drawing.Point(20, 178);
            this.panel_main_button_borrow_return.Name = "panel_main_button_borrow_return";
            this.panel_main_button_borrow_return.Size = new System.Drawing.Size(253, 155);
            this.panel_main_button_borrow_return.TabIndex = 0;
            this.panel_main_button_borrow_return.Text = "BORROW/RETURN";
            this.panel_main_button_borrow_return.UseVisualStyleBackColor = false;
            // 
            // label_dropmenu
            // 
            this.label_dropmenu.AutoSize = true;
            this.label_dropmenu.BackColor = System.Drawing.Color.Transparent;
            this.label_dropmenu.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dropmenu.ForeColor = System.Drawing.Color.White;
            this.label_dropmenu.Location = new System.Drawing.Point(17, 17);
            this.label_dropmenu.Name = "label_dropmenu";
            this.label_dropmenu.Size = new System.Drawing.Size(34, 29);
            this.label_dropmenu.TabIndex = 10;
            this.label_dropmenu.Text = "•••";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(924, 585);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(151, 19);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "hh:mm:ss dd:mm:yy";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.BackColor = System.Drawing.Color.Transparent;
            this.label_position.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.ForeColor = System.Drawing.Color.Black;
            this.label_position.Location = new System.Drawing.Point(16, 584);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(125, 19);
            this.label_position.TabIndex = 8;
            this.label_position.Text = "login as Position";
            // 
            // label_report
            // 
            this.label_report.AutoSize = true;
            this.label_report.BackColor = System.Drawing.Color.Transparent;
            this.label_report.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_report.ForeColor = System.Drawing.Color.White;
            this.label_report.Location = new System.Drawing.Point(17, 370);
            this.label_report.Name = "label_report";
            this.label_report.Size = new System.Drawing.Size(101, 29);
            this.label_report.TabIndex = 7;
            this.label_report.Text = "REPORT";
            // 
            // label_myprofile
            // 
            this.label_myprofile.AutoSize = true;
            this.label_myprofile.BackColor = System.Drawing.Color.Transparent;
            this.label_myprofile.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_myprofile.ForeColor = System.Drawing.Color.White;
            this.label_myprofile.Location = new System.Drawing.Point(17, 325);
            this.label_myprofile.Name = "label_myprofile";
            this.label_myprofile.Size = new System.Drawing.Size(142, 29);
            this.label_myprofile.TabIndex = 6;
            this.label_myprofile.Text = "MY PROFILE";
            // 
            // label_readers
            // 
            this.label_readers.AutoSize = true;
            this.label_readers.BackColor = System.Drawing.Color.Transparent;
            this.label_readers.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_readers.ForeColor = System.Drawing.Color.White;
            this.label_readers.Location = new System.Drawing.Point(17, 279);
            this.label_readers.Name = "label_readers";
            this.label_readers.Size = new System.Drawing.Size(120, 29);
            this.label_readers.TabIndex = 5;
            this.label_readers.Text = "READERS";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(17, 232);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(129, 29);
            this.label_category.TabIndex = 4;
            this.label_category.Text = "CATEGORY";
            // 
            // label_books
            // 
            this.label_books.AutoSize = true;
            this.label_books.BackColor = System.Drawing.Color.Transparent;
            this.label_books.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books.ForeColor = System.Drawing.Color.White;
            this.label_books.Location = new System.Drawing.Point(17, 182);
            this.label_books.Name = "label_books";
            this.label_books.Size = new System.Drawing.Size(88, 29);
            this.label_books.TabIndex = 3;
            this.label_books.Text = "BOOKS";
            // 
            // label_borrow_return
            // 
            this.label_borrow_return.AutoSize = true;
            this.label_borrow_return.BackColor = System.Drawing.Color.Transparent;
            this.label_borrow_return.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_borrow_return.ForeColor = System.Drawing.Color.White;
            this.label_borrow_return.Location = new System.Drawing.Point(17, 133);
            this.label_borrow_return.Name = "label_borrow_return";
            this.label_borrow_return.Size = new System.Drawing.Size(209, 29);
            this.label_borrow_return.TabIndex = 2;
            this.label_borrow_return.Text = "BORROW/RETURN";
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Transparent;
            this.label_home.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.White;
            this.label_home.Location = new System.Drawing.Point(17, 83);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(77, 29);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "HOME";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1049, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 6);
            this.btn_close.TabIndex = 21;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 607);
            this.Controls.Add(this.panel_background);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_main_picbox_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_report;
        private System.Windows.Forms.Label label_myprofile;
        private System.Windows.Forms.Label label_readers;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_books;
        private System.Windows.Forms.Label label_borrow_return;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_dropmenu;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button panel_main_button_borrow_return;
        private System.Windows.Forms.Button panel_main_button_report;
        private System.Windows.Forms.Button panel_main_button_myprofile;
        private System.Windows.Forms.Button panel_main_button_readers;
        private System.Windows.Forms.Button panel_main_button_category;
        private System.Windows.Forms.Button panel_main_button_books;
        private System.Windows.Forms.Label label_email_address;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox panel_main_picbox_profile;
        private System.Windows.Forms.Button btn_close;
    }
}

