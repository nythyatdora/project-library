namespace project_library
{
    partial class TestLayout
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
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Outside = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Inside = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Top = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Foot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Search = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_Searchby = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Text_Searchby = new System.Windows.Forms.TextBox();
            this.Datagrid_Table = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_Delete = new System.Windows.Forms.Label();
            this.Label_Update = new System.Windows.Forms.Label();
            this.Label_Insert = new System.Windows.Forms.Label();
            this.Label_View = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_Refresh = new System.Windows.Forms.Label();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            this.tableLayoutPanel_Outside.SuspendLayout();
            this.tableLayoutPanel_Inside.SuspendLayout();
            this.tableLayoutPanel_Top.SuspendLayout();
            this.tableLayoutPanel_Foot.SuspendLayout();
            this.tableLayoutPanel_Search.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Table)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Head
            // 
            this.Panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(102)))), ((int)(((byte)(24)))));
            this.Panel_Head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Head.Location = new System.Drawing.Point(0, 0);
            this.Panel_Head.Name = "Panel_Head";
            this.Panel_Head.Size = new System.Drawing.Size(1000, 15);
            this.Panel_Head.TabIndex = 1;
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Panel_Background.Controls.Add(this.tableLayoutPanel_Outside);
            this.Panel_Background.Location = new System.Drawing.Point(0, 15);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(1000, 790);
            this.Panel_Background.TabIndex = 2;
            // 
            // tableLayoutPanel_Outside
            // 
            this.tableLayoutPanel_Outside.ColumnCount = 3;
            this.tableLayoutPanel_Outside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Outside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel_Outside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Outside.Controls.Add(this.tableLayoutPanel_Inside, 1, 0);
            this.tableLayoutPanel_Outside.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Outside.Name = "tableLayoutPanel_Outside";
            this.tableLayoutPanel_Outside.RowCount = 1;
            this.tableLayoutPanel_Outside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Outside.Size = new System.Drawing.Size(1000, 790);
            this.tableLayoutPanel_Outside.TabIndex = 0;
            // 
            // tableLayoutPanel_Inside
            // 
            this.tableLayoutPanel_Inside.ColumnCount = 1;
            this.tableLayoutPanel_Inside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Inside.Controls.Add(this.tableLayoutPanel_Top, 0, 1);
            this.tableLayoutPanel_Inside.Controls.Add(this.tableLayoutPanel_Foot, 0, 4);
            this.tableLayoutPanel_Inside.Controls.Add(this.Datagrid_Table, 0, 3);
            this.tableLayoutPanel_Inside.Location = new System.Drawing.Point(33, 3);
            this.tableLayoutPanel_Inside.Name = "tableLayoutPanel_Inside";
            this.tableLayoutPanel_Inside.RowCount = 5;
            this.tableLayoutPanel_Inside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Inside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel_Inside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Inside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_Inside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Inside.Size = new System.Drawing.Size(934, 784);
            this.tableLayoutPanel_Inside.TabIndex = 1;
            // 
            // tableLayoutPanel_Top
            // 
            this.tableLayoutPanel_Top.ColumnCount = 2;
            this.tableLayoutPanel_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Top.Controls.Add(this.Label_Close, 0, 0);
            this.tableLayoutPanel_Top.Controls.Add(this.tableLayoutPanel_Search, 1, 1);
            this.tableLayoutPanel_Top.Controls.Add(this.Label_Title, 0, 1);
            this.tableLayoutPanel_Top.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel_Top.Name = "tableLayoutPanel_Top";
            this.tableLayoutPanel_Top.RowCount = 2;
            this.tableLayoutPanel_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel_Top.Size = new System.Drawing.Size(928, 100);
            this.tableLayoutPanel_Top.TabIndex = 0;
            // 
            // tableLayoutPanel_Foot
            // 
            this.tableLayoutPanel_Foot.ColumnCount = 2;
            this.tableLayoutPanel_Foot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Foot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Foot.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel_Foot.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel_Foot.Location = new System.Drawing.Point(3, 746);
            this.tableLayoutPanel_Foot.Name = "tableLayoutPanel_Foot";
            this.tableLayoutPanel_Foot.RowCount = 1;
            this.tableLayoutPanel_Foot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Foot.Size = new System.Drawing.Size(928, 28);
            this.tableLayoutPanel_Foot.TabIndex = 1;
            // 
            // tableLayoutPanel_Search
            // 
            this.tableLayoutPanel_Search.ColumnCount = 1;
            this.tableLayoutPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Search.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Search.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel_Search.Location = new System.Drawing.Point(559, 30);
            this.tableLayoutPanel_Search.Name = "tableLayoutPanel_Search";
            this.tableLayoutPanel_Search.RowCount = 2;
            this.tableLayoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel_Search.Size = new System.Drawing.Size(366, 67);
            this.tableLayoutPanel_Search.TabIndex = 80;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Label_Searchby);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 23);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Label_Searchby
            // 
            this.Label_Searchby.AutoSize = true;
            this.Label_Searchby.BackColor = System.Drawing.Color.Transparent;
            this.Label_Searchby.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Searchby.ForeColor = System.Drawing.Color.White;
            this.Label_Searchby.Location = new System.Drawing.Point(274, 0);
            this.Label_Searchby.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Searchby.Name = "Label_Searchby";
            this.Label_Searchby.Size = new System.Drawing.Size(92, 23);
            this.Label_Searchby.TabIndex = 6;
            this.Label_Searchby.Text = "Search by";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Text_Searchby);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(360, 38);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // Text_Searchby
            // 
            this.Text_Searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Searchby.Location = new System.Drawing.Point(3, 3);
            this.Text_Searchby.Name = "Text_Searchby";
            this.Text_Searchby.Size = new System.Drawing.Size(357, 33);
            this.Text_Searchby.TabIndex = 31;
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
            this.Datagrid_Table.Location = new System.Drawing.Point(3, 158);
            this.Datagrid_Table.MultiSelect = false;
            this.Datagrid_Table.Name = "Datagrid_Table";
            this.Datagrid_Table.RowHeadersVisible = false;
            this.Datagrid_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datagrid_Table.Size = new System.Drawing.Size(928, 580);
            this.Datagrid_Table.TabIndex = 32;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Label_Delete);
            this.flowLayoutPanel3.Controls.Add(this.Label_Update);
            this.flowLayoutPanel3.Controls.Add(this.Label_Insert);
            this.flowLayoutPanel3.Controls.Add(this.Label_View);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(467, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(458, 22);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // Label_Delete
            // 
            this.Label_Delete.AutoSize = true;
            this.Label_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Label_Delete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Delete.ForeColor = System.Drawing.Color.White;
            this.Label_Delete.Location = new System.Drawing.Point(380, 0);
            this.Label_Delete.Name = "Label_Delete";
            this.Label_Delete.Size = new System.Drawing.Size(75, 23);
            this.Label_Delete.TabIndex = 57;
            this.Label_Delete.Text = "DELETE";
            // 
            // Label_Update
            // 
            this.Label_Update.AutoSize = true;
            this.Label_Update.BackColor = System.Drawing.Color.Transparent;
            this.Label_Update.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Update.ForeColor = System.Drawing.Color.White;
            this.Label_Update.Location = new System.Drawing.Point(296, 0);
            this.Label_Update.Name = "Label_Update";
            this.Label_Update.Size = new System.Drawing.Size(78, 23);
            this.Label_Update.TabIndex = 56;
            this.Label_Update.Text = "UPDATE";
            // 
            // Label_Insert
            // 
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.BackColor = System.Drawing.Color.Transparent;
            this.Label_Insert.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Insert.ForeColor = System.Drawing.Color.White;
            this.Label_Insert.Location = new System.Drawing.Point(218, 0);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Size = new System.Drawing.Size(72, 23);
            this.Label_Insert.TabIndex = 55;
            this.Label_Insert.Text = "INSERT";
            // 
            // Label_View
            // 
            this.Label_View.AutoSize = true;
            this.Label_View.BackColor = System.Drawing.Color.Transparent;
            this.Label_View.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View.ForeColor = System.Drawing.Color.White;
            this.Label_View.Location = new System.Drawing.Point(159, 0);
            this.Label_View.Name = "Label_View";
            this.Label_View.Size = new System.Drawing.Size(53, 23);
            this.Label_View.TabIndex = 54;
            this.Label_View.Text = "VIEW";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.Label_Refresh);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(458, 22);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // Label_Refresh
            // 
            this.Label_Refresh.AutoSize = true;
            this.Label_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Label_Refresh.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Refresh.ForeColor = System.Drawing.Color.White;
            this.Label_Refresh.Location = new System.Drawing.Point(3, 0);
            this.Label_Refresh.Name = "Label_Refresh";
            this.Label_Refresh.Size = new System.Drawing.Size(92, 23);
            this.Label_Refresh.TabIndex = 49;
            this.Label_Refresh.Text = "REFRESH";
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.BackColor = System.Drawing.Color.Transparent;
            this.Label_Close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(3, 0);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(55, 23);
            this.Label_Close.TabIndex = 81;
            this.Label_Close.Text = "close";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(3, 27);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(154, 73);
            this.Label_Title.TabIndex = 82;
            this.Label_Title.Text = "Title";
            // 
            // TestLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 805);
            this.Controls.Add(this.Panel_Background);
            this.Controls.Add(this.Panel_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestLayout";
            this.Text = "TestLayout";
            this.Panel_Background.ResumeLayout(false);
            this.tableLayoutPanel_Outside.ResumeLayout(false);
            this.tableLayoutPanel_Inside.ResumeLayout(false);
            this.tableLayoutPanel_Top.ResumeLayout(false);
            this.tableLayoutPanel_Top.PerformLayout();
            this.tableLayoutPanel_Foot.ResumeLayout(false);
            this.tableLayoutPanel_Search.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Table)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Head;
        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Outside;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Inside;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Top;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Foot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Label_Searchby;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox Text_Searchby;
        private System.Windows.Forms.DataGridView Datagrid_Table;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label Label_View;
        private System.Windows.Forms.Label Label_Delete;
        private System.Windows.Forms.Label Label_Update;
        private System.Windows.Forms.Label Label_Insert;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label Label_Refresh;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label Label_Title;
    }
}