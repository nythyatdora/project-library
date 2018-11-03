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
            this.cbo_filter = new System.Windows.Forms.ComboBox();
            this.txt_search_by = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.label_reset = new System.Windows.Forms.Label();
            this.label_filter = new System.Windows.Forms.Label();
            this.label_search_by = new System.Windows.Forms.Label();
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
            this.panel_body.Controls.Add(this.cbo_filter);
            this.panel_body.Controls.Add(this.txt_search_by);
            this.panel_body.Controls.Add(this.label_search);
            this.panel_body.Controls.Add(this.label_reset);
            this.panel_body.Controls.Add(this.label_filter);
            this.panel_body.Controls.Add(this.label_search_by);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(900, 350);
            this.panel_body.TabIndex = 1;
            // 
            // cbo_filter
            // 
            this.cbo_filter.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.cbo_filter.FormattingEnabled = true;
            this.cbo_filter.Location = new System.Drawing.Point(50, 225);
            this.cbo_filter.Name = "cbo_filter";
            this.cbo_filter.Size = new System.Drawing.Size(280, 33);
            this.cbo_filter.TabIndex = 49;
            // 
            // txt_search_by
            // 
            this.txt_search_by.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_by.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_by.Location = new System.Drawing.Point(50, 138);
            this.txt_search_by.Name = "txt_search_by";
            this.txt_search_by.Size = new System.Drawing.Size(800, 33);
            this.txt_search_by.TabIndex = 7;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(753, 299);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(93, 25);
            this.label_search.TabIndex = 6;
            this.label_search.Text = "SEARCH";
            // 
            // label_reset
            // 
            this.label_reset.AutoSize = true;
            this.label_reset.BackColor = System.Drawing.Color.Transparent;
            this.label_reset.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reset.ForeColor = System.Drawing.Color.White;
            this.label_reset.Location = new System.Drawing.Point(48, 299);
            this.label_reset.Name = "label_reset";
            this.label_reset.Size = new System.Drawing.Size(75, 25);
            this.label_reset.TabIndex = 5;
            this.label_reset.Text = "RESET";
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.BackColor = System.Drawing.Color.Transparent;
            this.label_filter.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filter.ForeColor = System.Drawing.Color.White;
            this.label_filter.Location = new System.Drawing.Point(44, 189);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(74, 33);
            this.label_filter.TabIndex = 4;
            this.label_filter.Text = "filter";
            // 
            // label_search_by
            // 
            this.label_search_by.AutoSize = true;
            this.label_search_by.BackColor = System.Drawing.Color.Transparent;
            this.label_search_by.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_by.ForeColor = System.Drawing.Color.White;
            this.label_search_by.Location = new System.Drawing.Point(44, 102);
            this.label_search_by.Name = "label_search_by";
            this.label_search_by.Size = new System.Drawing.Size(135, 33);
            this.label_search_by.TabIndex = 3;
            this.label_search_by.Text = "Search By";
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 350);
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
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_reset;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.Label label_search_by;
        private System.Windows.Forms.TextBox txt_search_by;
        private System.Windows.Forms.ComboBox cbo_filter;
    }
}