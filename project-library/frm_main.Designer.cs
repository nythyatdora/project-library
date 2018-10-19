﻿namespace project_library
{
    partial class frm_main
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBookLocate = new System.Windows.Forms.Button();
            this.btnBookTraffic = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(16, 282);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(92, 23);
            this.btnHelp.TabIndex = 66;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(16, 232);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(92, 23);
            this.btnOption.TabIndex = 65;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(16, 90);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(92, 23);
            this.btnRegistration.TabIndex = 64;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(16, 81);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(92, 23);
            this.btnBooks.TabIndex = 62;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnBookLocate
            // 
            this.btnBookLocate.Location = new System.Drawing.Point(16, 133);
            this.btnBookLocate.Name = "btnBookLocate";
            this.btnBookLocate.Size = new System.Drawing.Size(92, 23);
            this.btnBookLocate.TabIndex = 63;
            this.btnBookLocate.Text = "Books Location";
            this.btnBookLocate.UseVisualStyleBackColor = true;
            // 
            // btnBookTraffic
            // 
            this.btnBookTraffic.Location = new System.Drawing.Point(16, 182);
            this.btnBookTraffic.Name = "btnBookTraffic";
            this.btnBookTraffic.Size = new System.Drawing.Size(92, 23);
            this.btnBookTraffic.TabIndex = 68;
            this.btnBookTraffic.Text = "Books Traffic";
            this.btnBookTraffic.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.metroDateTime2);
            this.panel3.Location = new System.Drawing.Point(152, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 58);
            this.panel3.TabIndex = 75;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime2.Location = new System.Drawing.Point(830, 3);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnBooks);
            this.panel4.Controls.Add(this.btnBookTraffic);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnBookLocate);
            this.panel4.Controls.Add(this.btnHelp);
            this.panel4.Controls.Add(this.btnOption);
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 687);
            this.panel4.TabIndex = 74;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 155);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 22);
            this.label11.TabIndex = 74;
            this.label11.Text = "User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(1011, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 187);
            this.panel2.TabIndex = 77;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.panel4);
            this.Name = "frm_main";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnBookLocate;
        private System.Windows.Forms.Button btnBookTraffic;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
    }
}
