namespace project_library
{
    partial class Panel_MyProfile_One
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_MyProfile_One));
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Email_Address = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Picbox_Profile = new System.Windows.Forms.PictureBox();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Email_Address);
            this.Panel_Body.Controls.Add(this.Label_Username);
            this.Panel_Body.Controls.Add(this.Picbox_Profile);
            this.Panel_Body.Location = new System.Drawing.Point(0, 0);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(852, 579);
            this.Panel_Body.TabIndex = 13;
            // 
            // Label_Email_Address
            // 
            this.Label_Email_Address.AutoSize = true;
            this.Label_Email_Address.BackColor = System.Drawing.Color.Transparent;
            this.Label_Email_Address.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email_Address.ForeColor = System.Drawing.Color.White;
            this.Label_Email_Address.Location = new System.Drawing.Point(308, 488);
            this.Label_Email_Address.Name = "Label_Email_Address";
            this.Label_Email_Address.Size = new System.Drawing.Size(231, 29);
            this.Label_Email_Address.TabIndex = 17;
            this.Label_Email_Address.Text = "email@address.com";
            this.Label_Email_Address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.BackColor = System.Drawing.Color.Transparent;
            this.Label_Username.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.Color.White;
            this.Label_Username.Location = new System.Drawing.Point(365, 460);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(121, 29);
            this.Label_Username.TabIndex = 16;
            this.Label_Username.Text = "username";
            this.Label_Username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Picbox_Profile
            // 
            this.Picbox_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picbox_Profile.Location = new System.Drawing.Point(277, 167);
            this.Picbox_Profile.Name = "Picbox_Profile";
            this.Picbox_Profile.Size = new System.Drawing.Size(299, 299);
            this.Picbox_Profile.TabIndex = 15;
            this.Picbox_Profile.TabStop = false;
            // 
            // Panel_Form_MyProfile_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 579);
            this.Controls.Add(this.Panel_Body);
            this.Name = "Panel_Form_MyProfile_One";
            this.Text = "Panel_Form_MyProfile_One";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.PictureBox Picbox_Profile;
        private System.Windows.Forms.Label Label_Email_Address;
        private System.Windows.Forms.Label Label_Username;
    }
}