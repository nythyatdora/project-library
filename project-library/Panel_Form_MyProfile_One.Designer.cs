namespace project_library
{
    partial class Panel_Form_MyProfile_One
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Form_MyProfile_One));
            this.panel_home = new System.Windows.Forms.Panel();
            this.picbox_profile = new System.Windows.Forms.PictureBox();
            this.label_email_address = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_home
            // 
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.Controls.Add(this.label_email_address);
            this.panel_home.Controls.Add(this.label_username);
            this.panel_home.Controls.Add(this.picbox_profile);
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(852, 579);
            this.panel_home.TabIndex = 13;
            // 
            // picbox_profile
            // 
            this.picbox_profile.BackColor = System.Drawing.Color.Transparent;
            this.picbox_profile.Location = new System.Drawing.Point(277, 167);
            this.picbox_profile.Name = "picbox_profile";
            this.picbox_profile.Size = new System.Drawing.Size(299, 299);
            this.picbox_profile.TabIndex = 15;
            this.picbox_profile.TabStop = false;
            // 
            // label_email_address
            // 
            this.label_email_address.AutoSize = true;
            this.label_email_address.BackColor = System.Drawing.Color.Transparent;
            this.label_email_address.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_address.ForeColor = System.Drawing.Color.White;
            this.label_email_address.Location = new System.Drawing.Point(308, 488);
            this.label_email_address.Name = "label_email_address";
            this.label_email_address.Size = new System.Drawing.Size(231, 29);
            this.label_email_address.TabIndex = 17;
            this.label_email_address.Text = "email@address.com";
            this.label_email_address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(365, 460);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(121, 29);
            this.label_username.TabIndex = 16;
            this.label_username.Text = "username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Panel_Form_MyProfile_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 579);
            this.Controls.Add(this.panel_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_Form_MyProfile_One";
            this.Text = "Panel_Form_MyProfile_One";
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
    }
}