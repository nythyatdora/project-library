using System.Drawing;

namespace project_library
{
    partial class Form_Borrow_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Borrow_Return));
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Picbox_Profile = new System.Windows.Forms.PictureBox();
            this.Label_Email_Address = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Button_Borrow = new System.Windows.Forms.Button();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Body.Controls.Add(this.Button_Return);
            this.Panel_Body.Controls.Add(this.Picbox_Profile);
            this.Panel_Body.Controls.Add(this.Label_Email_Address);
            this.Panel_Body.Controls.Add(this.Label_Username);
            this.Panel_Body.Controls.Add(this.Button_Borrow);
            this.Panel_Body.Location = new System.Drawing.Point(0, 0);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(852, 579);
            this.Panel_Body.TabIndex = 13;
            // 
            // Button_Return
            // 
            this.Button_Return.BackColor = System.Drawing.Color.Transparent;
            this.Button_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Return.FlatAppearance.BorderSize = 0;
            this.Button_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Return.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.Button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Return.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Return.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Return.Image = global::project_library.Properties.Resources.imgButtonLeft_Round;
            this.Button_Return.Location = new System.Drawing.Point(474, 183);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(283, 285);
            this.Button_Return.TabIndex = 15;
            this.Button_Return.Text = "RETURN";
            this.Button_Return.UseVisualStyleBackColor = false;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            this.Button_Return.MouseEnter += new System.EventHandler(this.Button_Return_MouseEnter);
            this.Button_Return.MouseLeave += new System.EventHandler(this.Button_Return_MouseLeave);
            // 
            // Picbox_Profile
            // 
            this.Picbox_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picbox_Profile.Location = new System.Drawing.Point(764, 21);
            this.Picbox_Profile.Name = "Picbox_Profile";
            this.Picbox_Profile.Size = new System.Drawing.Size(63, 65);
            this.Picbox_Profile.TabIndex = 14;
            this.Picbox_Profile.TabStop = false;
            // 
            // Label_Email_Address
            // 
            this.Label_Email_Address.AutoSize = true;
            this.Label_Email_Address.BackColor = System.Drawing.Color.Transparent;
            this.Label_Email_Address.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email_Address.ForeColor = System.Drawing.Color.White;
            this.Label_Email_Address.Location = new System.Drawing.Point(599, 53);
            this.Label_Email_Address.Name = "Label_Email_Address";
            this.Label_Email_Address.Size = new System.Drawing.Size(158, 19);
            this.Label_Email_Address.TabIndex = 13;
            this.Label_Email_Address.Text = "email@address.com";
            this.Label_Email_Address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.BackColor = System.Drawing.Color.Transparent;
            this.Label_Username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.Color.White;
            this.Label_Username.Location = new System.Drawing.Point(674, 34);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(83, 19);
            this.Label_Username.TabIndex = 12;
            this.Label_Username.Text = "username";
            this.Label_Username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Button_Borrow
            // 
            this.Button_Borrow.BackColor = System.Drawing.Color.Transparent;
            this.Button_Borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Borrow.FlatAppearance.BorderSize = 0;
            this.Button_Borrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Borrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Borrow.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.Button_Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Borrow.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Borrow.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Borrow.Image = global::project_library.Properties.Resources.imgButtonLeft_Round;
            this.Button_Borrow.Location = new System.Drawing.Point(81, 183);
            this.Button_Borrow.Name = "Button_Borrow";
            this.Button_Borrow.Size = new System.Drawing.Size(283, 285);
            this.Button_Borrow.TabIndex = 0;
            this.Button_Borrow.Text = "BORROW";
            this.Button_Borrow.UseVisualStyleBackColor = false;
            this.Button_Borrow.Click += new System.EventHandler(this.Button_Borrow_Click);
            this.Button_Borrow.MouseEnter += new System.EventHandler(this.Button_Borrow_MouseEnter);
            this.Button_Borrow.MouseLeave += new System.EventHandler(this.Button_Borrow_MouseLeave);
            // 
            // Form_Borrow_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 579);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Borrow_Return";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.PictureBox Picbox_Profile;
        private System.Windows.Forms.Label Label_Email_Address;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Button Button_Borrow;
    }
}