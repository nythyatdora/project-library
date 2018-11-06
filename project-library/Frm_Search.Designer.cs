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
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Combo_Filter = new System.Windows.Forms.ComboBox();
            this.Text_Searchby = new System.Windows.Forms.TextBox();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Label_Reset = new System.Windows.Forms.Label();
            this.Label_Filter = new System.Windows.Forms.Label();
            this.Label_Searchby = new System.Windows.Forms.Label();
            this.Panel_Body.SuspendLayout();
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
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Close);
            this.Panel_Body.Controls.Add(this.Combo_Filter);
            this.Panel_Body.Controls.Add(this.Text_Searchby);
            this.Panel_Body.Controls.Add(this.Label_Search);
            this.Panel_Body.Controls.Add(this.Label_Reset);
            this.Panel_Body.Controls.Add(this.Label_Filter);
            this.Panel_Body.Controls.Add(this.Label_Searchby);
            this.Panel_Body.Location = new System.Drawing.Point(0, 0);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(900, 350);
            this.Panel_Body.TabIndex = 1;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.BackColor = System.Drawing.Color.Transparent;
            this.Label_Close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(23, 18);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(55, 23);
            this.Label_Close.TabIndex = 77;
            this.Label_Close.Text = "close";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // Combo_Filter
            // 
            this.Combo_Filter.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.Combo_Filter.FormattingEnabled = true;
            this.Combo_Filter.Location = new System.Drawing.Point(50, 225);
            this.Combo_Filter.Name = "Combo_Filter";
            this.Combo_Filter.Size = new System.Drawing.Size(280, 33);
            this.Combo_Filter.TabIndex = 49;
            // 
            // Text_Searchby
            // 
            this.Text_Searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Searchby.Location = new System.Drawing.Point(50, 138);
            this.Text_Searchby.Name = "Text_Searchby";
            this.Text_Searchby.Size = new System.Drawing.Size(800, 33);
            this.Text_Searchby.TabIndex = 7;
            // 
            // Label_Search
            // 
            this.Label_Search.AutoSize = true;
            this.Label_Search.BackColor = System.Drawing.Color.Transparent;
            this.Label_Search.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Search.ForeColor = System.Drawing.Color.White;
            this.Label_Search.Location = new System.Drawing.Point(753, 299);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(93, 25);
            this.Label_Search.TabIndex = 6;
            this.Label_Search.Text = "SEARCH";
            this.Label_Search.MouseEnter += new System.EventHandler(this.Label_Search_MouseEnter);
            this.Label_Search.MouseLeave += new System.EventHandler(this.Label_Search_MouseLeave);
            // 
            // Label_Reset
            // 
            this.Label_Reset.AutoSize = true;
            this.Label_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Label_Reset.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reset.ForeColor = System.Drawing.Color.White;
            this.Label_Reset.Location = new System.Drawing.Point(48, 299);
            this.Label_Reset.Name = "Label_Reset";
            this.Label_Reset.Size = new System.Drawing.Size(75, 25);
            this.Label_Reset.TabIndex = 5;
            this.Label_Reset.Text = "RESET";
            this.Label_Reset.MouseEnter += new System.EventHandler(this.Label_Reset_MouseEnter);
            this.Label_Reset.MouseLeave += new System.EventHandler(this.Label_Reset_MouseLeave);
            // 
            // Label_Filter
            // 
            this.Label_Filter.AutoSize = true;
            this.Label_Filter.BackColor = System.Drawing.Color.Transparent;
            this.Label_Filter.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Filter.ForeColor = System.Drawing.Color.White;
            this.Label_Filter.Location = new System.Drawing.Point(44, 189);
            this.Label_Filter.Name = "Label_Filter";
            this.Label_Filter.Size = new System.Drawing.Size(74, 33);
            this.Label_Filter.TabIndex = 4;
            this.Label_Filter.Text = "filter";
            // 
            // Label_Searchby
            // 
            this.Label_Searchby.AutoSize = true;
            this.Label_Searchby.BackColor = System.Drawing.Color.Transparent;
            this.Label_Searchby.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Searchby.ForeColor = System.Drawing.Color.White;
            this.Label_Searchby.Location = new System.Drawing.Point(44, 102);
            this.Label_Searchby.Name = "Label_Searchby";
            this.Label_Searchby.Size = new System.Drawing.Size(135, 33);
            this.Label_Searchby.TabIndex = 3;
            this.Label_Searchby.Text = "Search By";
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 350);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Search";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.Label Label_Reset;
        private System.Windows.Forms.Label Label_Filter;
        private System.Windows.Forms.Label Label_Searchby;
        private System.Windows.Forms.TextBox Text_Searchby;
        private System.Windows.Forms.ComboBox Combo_Filter;
        private System.Windows.Forms.Label Label_Close;
    }
}