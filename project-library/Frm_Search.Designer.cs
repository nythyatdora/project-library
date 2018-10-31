namespace project_library
{
    partial class Frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            this.panel_head = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_book_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_book_title = new System.Windows.Forms.TextBox();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_head.BackgroundImage")));
            this.panel_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(900, 6);
            this.panel_head.TabIndex = 0;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_body.Controls.Add(this.cbo_gender);
            this.panel_body.Controls.Add(this.txt_book_title);
            this.panel_body.Controls.Add(this.label3);
            this.panel_body.Controls.Add(this.label2);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.label_book_title);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(900, 350);
            this.panel_body.TabIndex = 1;
            // 
            // label_book_title
            // 
            this.label_book_title.AutoSize = true;
            this.label_book_title.BackColor = System.Drawing.Color.Transparent;
            this.label_book_title.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_book_title.ForeColor = System.Drawing.Color.White;
            this.label_book_title.Location = new System.Drawing.Point(44, 102);
            this.label_book_title.Name = "label_book_title";
            this.label_book_title.Size = new System.Drawing.Size(135, 33);
            this.label_book_title.TabIndex = 3;
            this.label_book_title.Text = "Search By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(753, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEARCH";
            // 
            // txt_book_title
            // 
            this.txt_book_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_book_title.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_title.Location = new System.Drawing.Point(50, 138);
            this.txt_book_title.Name = "txt_book_title";
            this.txt_book_title.Size = new System.Drawing.Size(800, 33);
            this.txt_book_title.TabIndex = 7;
            // 
            // cbo_gender
            // 
            this.cbo_gender.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Location = new System.Drawing.Point(50, 225);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(280, 33);
            this.cbo_gender.TabIndex = 49;
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 356);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Search";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_book_title;
        private System.Windows.Forms.TextBox txt_book_title;
        private System.Windows.Forms.ComboBox cbo_gender;
    }
}