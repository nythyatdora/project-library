namespace project_library
{
    partial class Panel_Form_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Form_Books));
            this.panel_home = new System.Windows.Forms.Panel();
            this.picbox_profile = new System.Windows.Forms.PictureBox();
            this.label_email_address = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.btn_insert_book = new System.Windows.Forms.Button();
            this.btn_find_book = new System.Windows.Forms.Button();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_home
            // 
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.Controls.Add(this.btn_find_book);
            this.panel_home.Controls.Add(this.picbox_profile);
            this.panel_home.Controls.Add(this.label_email_address);
            this.panel_home.Controls.Add(this.label_username);
            this.panel_home.Controls.Add(this.btn_insert_book);
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(852, 579);
            this.panel_home.TabIndex = 12;
            // 
            // picbox_profile
            // 
            this.picbox_profile.BackColor = System.Drawing.Color.Transparent;
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
            // Panel_Form_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 579);
            this.Controls.Add(this.panel_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_Form_Books";
            this.Text = "Panel_Form_Books";
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.PictureBox picbox_profile;
        private System.Windows.Forms.Label label_email_address;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button btn_insert_book;
        private System.Windows.Forms.Button btn_find_book;
    }
}