namespace project_library
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel_background = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_confirm = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.picbox_password = new System.Windows.Forms.PictureBox();
            this.picbox_username = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbox_login = new System.Windows.Forms.PictureBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_login)).BeginInit();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_background.BackgroundImage")));
            this.panel_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_background.Controls.Add(this.label_exit);
            this.panel_background.Controls.Add(this.label_confirm);
            this.panel_background.Controls.Add(this.txt_password);
            this.panel_background.Controls.Add(this.txt_username);
            this.panel_background.Controls.Add(this.picbox_password);
            this.panel_background.Controls.Add(this.picbox_username);
            this.panel_background.Controls.Add(this.pictureBox1);
            this.panel_background.Controls.Add(this.picbox_login);
            this.panel_background.Location = new System.Drawing.Point(0, 1);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(399, 399);
            this.panel_background.TabIndex = 0;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Transparent;
            this.label_exit.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(325, 347);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(62, 35);
            this.label_exit.TabIndex = 9;
            this.label_exit.Text = "exit";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_confirm
            // 
            this.label_confirm.AutoSize = true;
            this.label_confirm.BackColor = System.Drawing.Color.Transparent;
            this.label_confirm.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirm.ForeColor = System.Drawing.Color.White;
            this.label_confirm.Location = new System.Drawing.Point(273, 312);
            this.label_confirm.Name = "label_confirm";
            this.label_confirm.Size = new System.Drawing.Size(114, 35);
            this.label_confirm.TabIndex = 8;
            this.label_confirm.Text = "confirm";
            this.label_confirm.Click += new System.EventHandler(this.label_confirm_Click);
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(20, 251);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(359, 33);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(20, 167);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(359, 33);
            this.txt_username.TabIndex = 4;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picbox_password
            // 
            this.picbox_password.BackColor = System.Drawing.Color.Transparent;
            this.picbox_password.Image = ((System.Drawing.Image)(resources.GetObject("picbox_password.Image")));
            this.picbox_password.Location = new System.Drawing.Point(252, 216);
            this.picbox_password.Name = "picbox_password";
            this.picbox_password.Size = new System.Drawing.Size(127, 29);
            this.picbox_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_password.TabIndex = 3;
            this.picbox_password.TabStop = false;
            // 
            // picbox_username
            // 
            this.picbox_username.BackColor = System.Drawing.Color.Transparent;
            this.picbox_username.Image = ((System.Drawing.Image)(resources.GetObject("picbox_username.Image")));
            this.picbox_username.Location = new System.Drawing.Point(247, 144);
            this.picbox_username.Name = "picbox_username";
            this.picbox_username.Size = new System.Drawing.Size(132, 17);
            this.picbox_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_username.TabIndex = 2;
            this.picbox_username.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picbox_login
            // 
            this.picbox_login.BackColor = System.Drawing.Color.Transparent;
            this.picbox_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_login.BackgroundImage")));
            this.picbox_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_login.Location = new System.Drawing.Point(15, 33);
            this.picbox_login.Name = "picbox_login";
            this.picbox_login.Size = new System.Drawing.Size(144, 51);
            this.picbox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_login.TabIndex = 0;
            this.picbox_login.TabStop = false;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.Controls.Add(this.panel_background);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(400, 400);
            this.panel_body.TabIndex = 1;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_login)).EndInit();
            this.panel_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox picbox_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbox_password;
        private System.Windows.Forms.PictureBox picbox_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_confirm;
    }
}