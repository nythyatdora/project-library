namespace project_library
{
    partial class Form_Import_Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Import_Text));
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Text_Input = new System.Windows.Forms.TextBox();
            this.Label_Confirm = new System.Windows.Forms.Label();
            this.Label_Reset = new System.Windows.Forms.Label();
            this.Label_Browse = new System.Windows.Forms.Label();
            this.Panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Head
            // 
            this.Panel_Head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Head.BackgroundImage")));
            this.Panel_Head.Location = new System.Drawing.Point(0, 0);
            this.Panel_Head.Name = "Panel_Head";
            this.Panel_Head.Size = new System.Drawing.Size(500, 6);
            this.Panel_Head.TabIndex = 0;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Browse);
            this.Panel_Body.Controls.Add(this.Label_Confirm);
            this.Panel_Body.Controls.Add(this.Label_Reset);
            this.Panel_Body.Controls.Add(this.Text_Input);
            this.Panel_Body.Controls.Add(this.Label_Title);
            this.Panel_Body.Controls.Add(this.Label_Close);
            this.Panel_Body.Location = new System.Drawing.Point(0, 6);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(500, 355);
            this.Panel_Body.TabIndex = 1;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.BackColor = System.Drawing.Color.Transparent;
            this.Label_Close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(28, 18);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(55, 23);
            this.Label_Close.TabIndex = 57;
            this.Label_Close.Text = "close";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Bahnschrift", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(23, 41);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(235, 52);
            this.Label_Title.TabIndex = 58;
            this.Label_Title.Text = "Import Text";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_Input
            // 
            this.Text_Input.Location = new System.Drawing.Point(32, 105);
            this.Text_Input.Multiline = true;
            this.Text_Input.Name = "Text_Input";
            this.Text_Input.Size = new System.Drawing.Size(435, 200);
            this.Text_Input.TabIndex = 59;
            // 
            // Label_Confirm
            // 
            this.Label_Confirm.AutoSize = true;
            this.Label_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Label_Confirm.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Confirm.ForeColor = System.Drawing.Color.White;
            this.Label_Confirm.Location = new System.Drawing.Point(377, 317);
            this.Label_Confirm.Name = "Label_Confirm";
            this.Label_Confirm.Size = new System.Drawing.Size(90, 23);
            this.Label_Confirm.TabIndex = 61;
            this.Label_Confirm.Text = "CONFIRM";
            this.Label_Confirm.MouseEnter += new System.EventHandler(this.Label_Confirm_MouseEnter);
            this.Label_Confirm.MouseLeave += new System.EventHandler(this.Label_Confirm_MouseLeave);
            // 
            // Label_Reset
            // 
            this.Label_Reset.AutoSize = true;
            this.Label_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Label_Reset.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reset.ForeColor = System.Drawing.Color.White;
            this.Label_Reset.Location = new System.Drawing.Point(28, 317);
            this.Label_Reset.Name = "Label_Reset";
            this.Label_Reset.Size = new System.Drawing.Size(65, 23);
            this.Label_Reset.TabIndex = 60;
            this.Label_Reset.Text = "RESET";
            this.Label_Reset.MouseEnter += new System.EventHandler(this.Label_Reset_MouseEnter);
            this.Label_Reset.MouseLeave += new System.EventHandler(this.Label_Reset_MouseLeave);
            // 
            // Label_Browse
            // 
            this.Label_Browse.AutoSize = true;
            this.Label_Browse.BackColor = System.Drawing.Color.Transparent;
            this.Label_Browse.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Browse.ForeColor = System.Drawing.Color.White;
            this.Label_Browse.Location = new System.Drawing.Point(382, 70);
            this.Label_Browse.Name = "Label_Browse";
            this.Label_Browse.Size = new System.Drawing.Size(85, 23);
            this.Label_Browse.TabIndex = 62;
            this.Label_Browse.Text = "BROWSE";
            this.Label_Browse.MouseEnter += new System.EventHandler(this.Label_Browse_MouseEnter);
            this.Label_Browse.MouseLeave += new System.EventHandler(this.Label_Browse_MouseLeave);
            // 
            // Form_Import_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 361);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.Panel_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Import_Text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Import_Text";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Head;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TextBox Text_Input;
        private System.Windows.Forms.Label Label_Confirm;
        private System.Windows.Forms.Label Label_Reset;
        private System.Windows.Forms.Label Label_Browse;
    }
}