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
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Delete = new System.Windows.Forms.Label();
            this.Label_Update = new System.Windows.Forms.Label();
            this.Label_Insert = new System.Windows.Forms.Label();
            this.Label_View = new System.Windows.Forms.Label();
            this.Label_Refresh = new System.Windows.Forms.Label();
            this.Datagrid_Table = new System.Windows.Forms.DataGridView();
            this.Text_Searchby = new System.Windows.Forms.TextBox();
            this.Label_Searchby = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Head
            // 
            this.Panel_Head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Head.BackgroundImage")));
            this.Panel_Head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Head.Location = new System.Drawing.Point(0, 0);
            this.Panel_Head.Name = "Panel_Head";
            this.Panel_Head.Size = new System.Drawing.Size(1000, 6);
            this.Panel_Head.TabIndex = 0;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Close);
            this.Panel_Body.Controls.Add(this.Label_Delete);
            this.Panel_Body.Controls.Add(this.Label_Update);
            this.Panel_Body.Controls.Add(this.Label_Insert);
            this.Panel_Body.Controls.Add(this.Label_View);
            this.Panel_Body.Controls.Add(this.Label_Refresh);
            this.Panel_Body.Controls.Add(this.Datagrid_Table);
            this.Panel_Body.Controls.Add(this.Text_Searchby);
            this.Panel_Body.Controls.Add(this.Label_Searchby);
            this.Panel_Body.Controls.Add(this.Label_Title);
            this.Panel_Body.Location = new System.Drawing.Point(0, 6);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1000, 794);
            this.Panel_Body.TabIndex = 1;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.BackColor = System.Drawing.Color.Transparent;
            this.Label_Close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(21, 18);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(55, 23);
            this.Label_Close.TabIndex = 77;
            this.Label_Close.Text = "close";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // Label_Delete
            // 
            this.Label_Delete.AutoSize = true;
            this.Label_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Label_Delete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Delete.ForeColor = System.Drawing.Color.White;
            this.Label_Delete.Location = new System.Drawing.Point(901, 749);
            this.Label_Delete.Name = "Label_Delete";
            this.Label_Delete.Size = new System.Drawing.Size(75, 23);
            this.Label_Delete.TabIndex = 52;
            this.Label_Delete.Text = "DELETE";
            this.Label_Delete.MouseEnter += new System.EventHandler(this.Label_Delete_MouseEnter);
            this.Label_Delete.MouseLeave += new System.EventHandler(this.Label_Delete_MouseLeave);
            // 
            // Label_Update
            // 
            this.Label_Update.AutoSize = true;
            this.Label_Update.BackColor = System.Drawing.Color.Transparent;
            this.Label_Update.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Update.ForeColor = System.Drawing.Color.White;
            this.Label_Update.Location = new System.Drawing.Point(794, 749);
            this.Label_Update.Name = "Label_Update";
            this.Label_Update.Size = new System.Drawing.Size(78, 23);
            this.Label_Update.TabIndex = 51;
            this.Label_Update.Text = "UPDATE";
            this.Label_Update.MouseEnter += new System.EventHandler(this.Label_Update_MouseEnter);
            this.Label_Update.MouseLeave += new System.EventHandler(this.Label_Update_MouseLeave);
            // 
            // Label_Insert
            // 
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.BackColor = System.Drawing.Color.Transparent;
            this.Label_Insert.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Insert.ForeColor = System.Drawing.Color.White;
            this.Label_Insert.Location = new System.Drawing.Point(691, 749);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Size = new System.Drawing.Size(72, 23);
            this.Label_Insert.TabIndex = 50;
            this.Label_Insert.Text = "INSERT";
            this.Label_Insert.MouseEnter += new System.EventHandler(this.Label_Insert_MouseEnter);
            this.Label_Insert.MouseLeave += new System.EventHandler(this.Label_Insert_MouseLeave);
            // 
            // Label_View
            // 
            this.Label_View.AutoSize = true;
            this.Label_View.BackColor = System.Drawing.Color.Transparent;
            this.Label_View.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View.ForeColor = System.Drawing.Color.White;
            this.Label_View.Location = new System.Drawing.Point(607, 749);
            this.Label_View.Name = "Label_View";
            this.Label_View.Size = new System.Drawing.Size(53, 23);
            this.Label_View.TabIndex = 49;
            this.Label_View.Text = "VIEW";
            this.Label_View.MouseEnter += new System.EventHandler(this.Label_View_MouseEnter);
            this.Label_View.MouseLeave += new System.EventHandler(this.Label_View_MouseLeave);
            // 
            // Label_Refresh
            // 
            this.Label_Refresh.AutoSize = true;
            this.Label_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Label_Refresh.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Refresh.ForeColor = System.Drawing.Color.White;
            this.Label_Refresh.Location = new System.Drawing.Point(23, 749);
            this.Label_Refresh.Name = "Label_Refresh";
            this.Label_Refresh.Size = new System.Drawing.Size(92, 23);
            this.Label_Refresh.TabIndex = 48;
            this.Label_Refresh.Text = "REFRESH";
            this.Label_Refresh.MouseEnter += new System.EventHandler(this.Label_Refresh_MouseEnter);
            this.Label_Refresh.MouseLeave += new System.EventHandler(this.Label_Refresh_MouseLeave);
            // 
            // Datagrid_Table
            // 
            this.Datagrid_Table.AllowUserToAddRows = false;
            this.Datagrid_Table.AllowUserToDeleteRows = false;
            this.Datagrid_Table.AllowUserToResizeColumns = false;
            this.Datagrid_Table.AllowUserToResizeRows = false;
            this.Datagrid_Table.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_Table.ColumnHeadersHeight = 30;
            this.Datagrid_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Datagrid_Table.Location = new System.Drawing.Point(25, 133);
            this.Datagrid_Table.MultiSelect = false;
            this.Datagrid_Table.Name = "Datagrid_Table";
            this.Datagrid_Table.RowHeadersVisible = false;
            this.Datagrid_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datagrid_Table.Size = new System.Drawing.Size(950, 600);
            this.Datagrid_Table.TabIndex = 31;
            // 
            // Text_Searchby
            // 
            this.Text_Searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Searchby.Location = new System.Drawing.Point(696, 63);
            this.Text_Searchby.Name = "Text_Searchby";
            this.Text_Searchby.Size = new System.Drawing.Size(280, 33);
            this.Text_Searchby.TabIndex = 30;
            // 
            // Label_Searchby
            // 
            this.Label_Searchby.AutoSize = true;
            this.Label_Searchby.BackColor = System.Drawing.Color.Transparent;
            this.Label_Searchby.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Searchby.ForeColor = System.Drawing.Color.White;
            this.Label_Searchby.Location = new System.Drawing.Point(883, 37);
            this.Label_Searchby.Name = "Label_Searchby";
            this.Label_Searchby.Size = new System.Drawing.Size(92, 23);
            this.Label_Searchby.TabIndex = 5;
            this.Label_Searchby.Text = "Search by";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(12, 37);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(154, 77);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "Title";
            // 
            // Frm_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.Panel_Head);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Table";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Head;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_Searchby;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.DataGridView Datagrid_Table;
        private System.Windows.Forms.TextBox Text_Searchby;
        private System.Windows.Forms.Label Label_Delete;
        private System.Windows.Forms.Label Label_Update;
        private System.Windows.Forms.Label Label_Insert;
        private System.Windows.Forms.Label Label_View;
        private System.Windows.Forms.Label Label_Refresh;
        private System.Windows.Forms.Label Label_Close;
    }
}