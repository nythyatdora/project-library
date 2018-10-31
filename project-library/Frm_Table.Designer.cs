namespace project_library
{
    partial class Frm_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Table));
            this.panel_head = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_delete = new System.Windows.Forms.Label();
            this.label_update = new System.Windows.Forms.Label();
            this.label_insert = new System.Windows.Forms.Label();
            this.label_view = new System.Windows.Forms.Label();
            this.label_refresh = new System.Windows.Forms.Label();
            this.datagrid_table = new System.Windows.Forms.DataGridView();
            this.txt_searchby = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_head.BackgroundImage")));
            this.panel_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1000, 6);
            this.panel_head.TabIndex = 0;
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_body.Controls.Add(this.label_delete);
            this.panel_body.Controls.Add(this.label_update);
            this.panel_body.Controls.Add(this.label_insert);
            this.panel_body.Controls.Add(this.label_view);
            this.panel_body.Controls.Add(this.label_refresh);
            this.panel_body.Controls.Add(this.datagrid_table);
            this.panel_body.Controls.Add(this.txt_searchby);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.label_title);
            this.panel_body.Location = new System.Drawing.Point(0, 6);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1000, 794);
            this.panel_body.TabIndex = 1;
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.BackColor = System.Drawing.Color.Transparent;
            this.label_delete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delete.ForeColor = System.Drawing.Color.White;
            this.label_delete.Location = new System.Drawing.Point(907, 749);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(75, 23);
            this.label_delete.TabIndex = 52;
            this.label_delete.Text = "DELETE";
            // 
            // label_update
            // 
            this.label_update.AutoSize = true;
            this.label_update.BackColor = System.Drawing.Color.Transparent;
            this.label_update.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_update.ForeColor = System.Drawing.Color.White;
            this.label_update.Location = new System.Drawing.Point(800, 749);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(78, 23);
            this.label_update.TabIndex = 51;
            this.label_update.Text = "UPDATE";
            // 
            // label_insert
            // 
            this.label_insert.AutoSize = true;
            this.label_insert.BackColor = System.Drawing.Color.Transparent;
            this.label_insert.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_insert.ForeColor = System.Drawing.Color.White;
            this.label_insert.Location = new System.Drawing.Point(697, 749);
            this.label_insert.Name = "label_insert";
            this.label_insert.Size = new System.Drawing.Size(72, 23);
            this.label_insert.TabIndex = 50;
            this.label_insert.Text = "INSERT";
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.BackColor = System.Drawing.Color.Transparent;
            this.label_view.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_view.ForeColor = System.Drawing.Color.White;
            this.label_view.Location = new System.Drawing.Point(613, 749);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(53, 23);
            this.label_view.TabIndex = 49;
            this.label_view.Text = "VIEW";
            // 
            // label_refresh
            // 
            this.label_refresh.AutoSize = true;
            this.label_refresh.BackColor = System.Drawing.Color.Transparent;
            this.label_refresh.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_refresh.ForeColor = System.Drawing.Color.White;
            this.label_refresh.Location = new System.Drawing.Point(23, 749);
            this.label_refresh.Name = "label_refresh";
            this.label_refresh.Size = new System.Drawing.Size(92, 23);
            this.label_refresh.TabIndex = 48;
            this.label_refresh.Text = "REFRESH";
            // 
            // datagrid_table
            // 
            this.datagrid_table.AllowUserToAddRows = false;
            this.datagrid_table.AllowUserToDeleteRows = false;
            this.datagrid_table.AllowUserToResizeColumns = false;
            this.datagrid_table.AllowUserToResizeRows = false;
            this.datagrid_table.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_table.ColumnHeadersHeight = 30;
            this.datagrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_table.Location = new System.Drawing.Point(25, 133);
            this.datagrid_table.MultiSelect = false;
            this.datagrid_table.Name = "datagrid_table";
            this.datagrid_table.RowHeadersVisible = false;
            this.datagrid_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_table.Size = new System.Drawing.Size(950, 600);
            this.datagrid_table.TabIndex = 31;
            // 
            // txt_searchby
            // 
            this.txt_searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchby.Location = new System.Drawing.Point(696, 63);
            this.txt_searchby.Name = "txt_searchby";
            this.txt_searchby.Size = new System.Drawing.Size(280, 33);
            this.txt_searchby.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(869, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH BY";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(12, 23);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(154, 77);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Title";
            // 
            // Frm_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Table";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView datagrid_table;
        private System.Windows.Forms.TextBox txt_searchby;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Label label_insert;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.Label label_refresh;
    }
}