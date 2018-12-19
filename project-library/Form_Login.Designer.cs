namespace project_library
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Label_Exit = new System.Windows.Forms.Label();
            this.Label_Confirm = new System.Windows.Forms.Label();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Text_Username = new System.Windows.Forms.TextBox();
            this.Picbox_Password = new System.Windows.Forms.PictureBox();
            this.Picbox_Username = new System.Windows.Forms.PictureBox();
            this.Picbox_Login = new System.Windows.Forms.PictureBox();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Login)).BeginInit();
            this.Panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Background.BackgroundImage")));
            this.Panel_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Background.Controls.Add(this.Panel_Head);
            this.Panel_Background.Controls.Add(this.Label_Exit);
            this.Panel_Background.Controls.Add(this.Label_Confirm);
            this.Panel_Background.Controls.Add(this.Text_Password);
            this.Panel_Background.Controls.Add(this.Text_Username);
            this.Panel_Background.Controls.Add(this.Picbox_Password);
            this.Panel_Background.Controls.Add(this.Picbox_Username);
            this.Panel_Background.Controls.Add(this.Picbox_Login);
            this.Panel_Background.Location = new System.Drawing.Point(0, 1);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(399, 399);
            this.Panel_Background.TabIndex = 0;
            // 
            // Panel_Head
            // 
            this.Panel_Head.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Head.BackgroundImage")));
            this.Panel_Head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Head.Location = new System.Drawing.Point(0, -1);
            this.Panel_Head.Name = "Panel_Head";
            this.Panel_Head.Size = new System.Drawing.Size(399, 6);
            this.Panel_Head.TabIndex = 10;
            // 
            // Label_Exit
            // 
            this.Label_Exit.AutoSize = true;
            this.Label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_Exit.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Exit.ForeColor = System.Drawing.Color.White;
            this.Label_Exit.Location = new System.Drawing.Point(325, 347);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.Size = new System.Drawing.Size(62, 35);
            this.Label_Exit.TabIndex = 9;
            this.Label_Exit.Text = "exit";
            this.Label_Exit.Click += new System.EventHandler(this.Label_Exit_Click);
            this.Label_Exit.MouseEnter += new System.EventHandler(this.Label_Exit_MouseEnter);
            this.Label_Exit.MouseLeave += new System.EventHandler(this.Label_Exit_MouseLeave);
            // 
            // Label_Confirm
            // 
            this.Label_Confirm.AutoSize = true;
            this.Label_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Label_Confirm.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Confirm.ForeColor = System.Drawing.Color.White;
            this.Label_Confirm.Location = new System.Drawing.Point(273, 312);
            this.Label_Confirm.Name = "Label_Confirm";
            this.Label_Confirm.Size = new System.Drawing.Size(114, 35);
            this.Label_Confirm.TabIndex = 8;
            this.Label_Confirm.Text = "confirm";
            this.Label_Confirm.Click += new System.EventHandler(this.Label_Confirm_Click);
            this.Label_Confirm.MouseEnter += new System.EventHandler(this.Label_Confirm_MouseEnter);
            this.Label_Confirm.MouseLeave += new System.EventHandler(this.Label_Confirm_MouseLeave);
            // 
            // Text_Password
            // 
            this.Text_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Password.Location = new System.Drawing.Point(20, 251);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(359, 33);
            this.Text_Password.TabIndex = 5;
            this.Text_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Text_Password.UseSystemPasswordChar = true;
            // 
            // Text_Username
            // 
            this.Text_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Username.Location = new System.Drawing.Point(20, 167);
            this.Text_Username.Name = "Text_Username";
            this.Text_Username.Size = new System.Drawing.Size(359, 33);
            this.Text_Username.TabIndex = 4;
            this.Text_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Picbox_Password
            // 
            this.Picbox_Password.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Password.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_Password.Image")));
            this.Picbox_Password.Location = new System.Drawing.Point(252, 216);
            this.Picbox_Password.Name = "Picbox_Password";
            this.Picbox_Password.Size = new System.Drawing.Size(127, 29);
            this.Picbox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picbox_Password.TabIndex = 3;
            this.Picbox_Password.TabStop = false;
            // 
            // Picbox_Username
            // 
            this.Picbox_Username.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Username.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_Username.Image")));
            this.Picbox_Username.Location = new System.Drawing.Point(247, 144);
            this.Picbox_Username.Name = "Picbox_Username";
            this.Picbox_Username.Size = new System.Drawing.Size(132, 17);
            this.Picbox_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picbox_Username.TabIndex = 2;
            this.Picbox_Username.TabStop = false;
            // 
            // Picbox_Login
            // 
            this.Picbox_Login.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picbox_Login.BackgroundImage")));
            this.Picbox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picbox_Login.Location = new System.Drawing.Point(15, 33);
            this.Picbox_Login.Name = "Picbox_Login";
            this.Picbox_Login.Size = new System.Drawing.Size(144, 51);
            this.Picbox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picbox_Login.TabIndex = 0;
            this.Picbox_Login.TabStop = false;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.Controls.Add(this.Panel_Background);
            this.Panel_Body.Location = new System.Drawing.Point(0, 0);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(400, 400);
            this.Panel_Body.TabIndex = 1;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Login)).EndInit();
            this.Panel_Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.PictureBox Picbox_Login;
        private System.Windows.Forms.PictureBox Picbox_Password;
        private System.Windows.Forms.PictureBox Picbox_Username;
        private System.Windows.Forms.TextBox Text_Username;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Label Label_Exit;
        private System.Windows.Forms.Label Label_Confirm;
        private System.Windows.Forms.Panel Panel_Head;
    }
}