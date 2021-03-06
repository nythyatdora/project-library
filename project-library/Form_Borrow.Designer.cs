﻿using System;

namespace project_library
{
    partial class Form_Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Borrow));
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Back = new System.Windows.Forms.Label();
            this.Datagrid_Table = new System.Windows.Forms.DataGridView();
            this.Label_View_Table_Books = new System.Windows.Forms.Label();
            this.Label_View_Table_Readers = new System.Windows.Forms.Label();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Next = new System.Windows.Forms.Label();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Label_Reset_Search = new System.Windows.Forms.Label();
            this.Combo_Filter = new System.Windows.Forms.ComboBox();
            this.Text_Searchby = new System.Windows.Forms.TextBox();
            this.Label_Filter = new System.Windows.Forms.Label();
            this.Label_Book_Title = new System.Windows.Forms.Label();
            this.Label_Add_New_Book = new System.Windows.Forms.Label();
            this.Label_Add_New_Reader = new System.Windows.Forms.Label();
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
            this.Panel_Head.Size = new System.Drawing.Size(900, 6);
            this.Panel_Head.TabIndex = 2;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Body.BackgroundImage")));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Back);
            this.Panel_Body.Controls.Add(this.Datagrid_Table);
            this.Panel_Body.Controls.Add(this.Label_View_Table_Books);
            this.Panel_Body.Controls.Add(this.Label_View_Table_Readers);
            this.Panel_Body.Controls.Add(this.Label_Close);
            this.Panel_Body.Controls.Add(this.Label_Next);
            this.Panel_Body.Controls.Add(this.Label_Search);
            this.Panel_Body.Controls.Add(this.Label_Reset_Search);
            this.Panel_Body.Controls.Add(this.Combo_Filter);
            this.Panel_Body.Controls.Add(this.Text_Searchby);
            this.Panel_Body.Controls.Add(this.Label_Filter);
            this.Panel_Body.Controls.Add(this.Label_Book_Title);
            this.Panel_Body.Controls.Add(this.Label_Add_New_Book);
            this.Panel_Body.Controls.Add(this.Label_Add_New_Reader);
            this.Panel_Body.Location = new System.Drawing.Point(0, 6);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(900, 685);
            this.Panel_Body.TabIndex = 3;
            // 
            // Label_Back
            // 
            this.Label_Back.AutoSize = true;
            this.Label_Back.BackColor = System.Drawing.Color.Transparent;
            this.Label_Back.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Back.ForeColor = System.Drawing.Color.White;
            this.Label_Back.Location = new System.Drawing.Point(33, 646);
            this.Label_Back.Name = "Label_Back";
            this.Label_Back.Size = new System.Drawing.Size(58, 23);
            this.Label_Back.TabIndex = 80;
            this.Label_Back.Text = "BACK";
            this.Label_Back.MouseEnter += new System.EventHandler(this.Label_Back_MouseEnter);
            this.Label_Back.MouseLeave += new System.EventHandler(this.Label_Back_MouseLeave);
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
            this.Datagrid_Table.Location = new System.Drawing.Point(37, 315);
            this.Datagrid_Table.MultiSelect = false;
            this.Datagrid_Table.Name = "Datagrid_Table";
            this.Datagrid_Table.RowHeadersVisible = false;
            this.Datagrid_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datagrid_Table.Size = new System.Drawing.Size(828, 315);
            this.Datagrid_Table.TabIndex = 79;
            // 
            // Label_View_Table_Books
            // 
            this.Label_View_Table_Books.AutoSize = true;
            this.Label_View_Table_Books.BackColor = System.Drawing.Color.Transparent;
            this.Label_View_Table_Books.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View_Table_Books.ForeColor = System.Drawing.Color.White;
            this.Label_View_Table_Books.Location = new System.Drawing.Point(630, 91);
            this.Label_View_Table_Books.Name = "Label_View_Table_Books";
            this.Label_View_Table_Books.Size = new System.Drawing.Size(105, 46);
            this.Label_View_Table_Books.TabIndex = 78;
            this.Label_View_Table_Books.Text = "view\r\ntable books";
            this.Label_View_Table_Books.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_View_Table_Books.MouseEnter += new System.EventHandler(this.Label_View_Table_Books_MouseEnter);
            this.Label_View_Table_Books.MouseLeave += new System.EventHandler(this.Label_View_Table_Books_MouseLeave);
            // 
            // Label_View_Table_Readers
            // 
            this.Label_View_Table_Readers.AutoSize = true;
            this.Label_View_Table_Readers.BackColor = System.Drawing.Color.Transparent;
            this.Label_View_Table_Readers.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View_Table_Readers.ForeColor = System.Drawing.Color.White;
            this.Label_View_Table_Readers.Location = new System.Drawing.Point(614, 31);
            this.Label_View_Table_Readers.Name = "Label_View_Table_Readers";
            this.Label_View_Table_Readers.Size = new System.Drawing.Size(121, 46);
            this.Label_View_Table_Readers.TabIndex = 77;
            this.Label_View_Table_Readers.Text = "view\r\ntable readers";
            this.Label_View_Table_Readers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_View_Table_Readers.MouseEnter += new System.EventHandler(this.Label_View_Table_Readers_MouseEnter);
            this.Label_View_Table_Readers.MouseLeave += new System.EventHandler(this.Label_View_Table_Readers_MouseLeave);
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
            this.Label_Close.TabIndex = 76;
            this.Label_Close.Text = "close";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // Label_Next
            // 
            this.Label_Next.AutoSize = true;
            this.Label_Next.BackColor = System.Drawing.Color.Transparent;
            this.Label_Next.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Next.ForeColor = System.Drawing.Color.White;
            this.Label_Next.Location = new System.Drawing.Point(811, 646);
            this.Label_Next.Name = "Label_Next";
            this.Label_Next.Size = new System.Drawing.Size(54, 23);
            this.Label_Next.TabIndex = 75;
            this.Label_Next.Text = "NEXT";
            this.Label_Next.MouseEnter += new System.EventHandler(this.Label_Next_MouseEnter);
            this.Label_Next.MouseLeave += new System.EventHandler(this.Label_Next_MouseLeave);
            // 
            // Label_Search
            // 
            this.Label_Search.AutoSize = true;
            this.Label_Search.BackColor = System.Drawing.Color.Transparent;
            this.Label_Search.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Search.ForeColor = System.Drawing.Color.White;
            this.Label_Search.Location = new System.Drawing.Point(791, 273);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(82, 23);
            this.Label_Search.TabIndex = 55;
            this.Label_Search.Text = "SEARCH";
            this.Label_Search.MouseEnter += new System.EventHandler(this.Label_Search_MouseEnter);
            this.Label_Search.MouseLeave += new System.EventHandler(this.Label_Search_MouseLeave);
            // 
            // Label_Reset_Search
            // 
            this.Label_Reset_Search.AutoSize = true;
            this.Label_Reset_Search.BackColor = System.Drawing.Color.Transparent;
            this.Label_Reset_Search.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reset_Search.ForeColor = System.Drawing.Color.White;
            this.Label_Reset_Search.Location = new System.Drawing.Point(33, 273);
            this.Label_Reset_Search.Name = "Label_Reset_Search";
            this.Label_Reset_Search.Size = new System.Drawing.Size(140, 23);
            this.Label_Reset_Search.TabIndex = 54;
            this.Label_Reset_Search.Text = "RESET SEARCH";
            this.Label_Reset_Search.MouseEnter += new System.EventHandler(this.Label_Reset_Search_MouseEnter);
            this.Label_Reset_Search.MouseLeave += new System.EventHandler(this.Label_Reset_Search_MouseLeave);
            // 
            // Combo_Filter
            // 
            this.Combo_Filter.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.Combo_Filter.FormattingEnabled = true;
            this.Combo_Filter.Location = new System.Drawing.Point(650, 217);
            this.Combo_Filter.Name = "Combo_Filter";
            this.Combo_Filter.Size = new System.Drawing.Size(215, 33);
            this.Combo_Filter.TabIndex = 53;
            // 
            // Text_Searchby
            // 
            this.Text_Searchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Searchby.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Searchby.Location = new System.Drawing.Point(37, 217);
            this.Text_Searchby.Name = "Text_Searchby";
            this.Text_Searchby.Size = new System.Drawing.Size(585, 33);
            this.Text_Searchby.TabIndex = 52;
            // 
            // Label_Filter
            // 
            this.Label_Filter.AutoSize = true;
            this.Label_Filter.BackColor = System.Drawing.Color.Transparent;
            this.Label_Filter.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Filter.ForeColor = System.Drawing.Color.White;
            this.Label_Filter.Location = new System.Drawing.Point(800, 185);
            this.Label_Filter.Name = "Label_Filter";
            this.Label_Filter.Size = new System.Drawing.Size(65, 29);
            this.Label_Filter.TabIndex = 51;
            this.Label_Filter.Text = "filter";
            // 
            // Label_Book_Title
            // 
            this.Label_Book_Title.AutoSize = true;
            this.Label_Book_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Book_Title.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Book_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Book_Title.Location = new System.Drawing.Point(32, 185);
            this.Label_Book_Title.Name = "Label_Book_Title";
            this.Label_Book_Title.Size = new System.Drawing.Size(118, 29);
            this.Label_Book_Title.TabIndex = 50;
            this.Label_Book_Title.Text = "Search by";
            // 
            // Label_Add_New_Book
            // 
            this.Label_Add_New_Book.AutoSize = true;
            this.Label_Add_New_Book.BackColor = System.Drawing.Color.Transparent;
            this.Label_Add_New_Book.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Add_New_Book.ForeColor = System.Drawing.Color.White;
            this.Label_Add_New_Book.Location = new System.Drawing.Point(776, 91);
            this.Label_Add_New_Book.Name = "Label_Add_New_Book";
            this.Label_Add_New_Book.Size = new System.Drawing.Size(89, 46);
            this.Label_Add_New_Book.TabIndex = 3;
            this.Label_Add_New_Book.Text = "add\r\nnew book";
            this.Label_Add_New_Book.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Add_New_Book.MouseEnter += new System.EventHandler(this.Label_Add_New_Book_MouseEnter);
            this.Label_Add_New_Book.MouseLeave += new System.EventHandler(this.Label_Add_New_Book_MouseLeave);
            // 
            // Label_Add_New_Reader
            // 
            this.Label_Add_New_Reader.AutoSize = true;
            this.Label_Add_New_Reader.BackColor = System.Drawing.Color.Transparent;
            this.Label_Add_New_Reader.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Add_New_Reader.ForeColor = System.Drawing.Color.White;
            this.Label_Add_New_Reader.Location = new System.Drawing.Point(760, 31);
            this.Label_Add_New_Reader.Name = "Label_Add_New_Reader";
            this.Label_Add_New_Reader.Size = new System.Drawing.Size(105, 46);
            this.Label_Add_New_Reader.TabIndex = 2;
            this.Label_Add_New_Reader.Text = "add\r\nnew reader";
            this.Label_Add_New_Reader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Add_New_Reader.MouseEnter += new System.EventHandler(this.Label_Add_New_Reader_MouseEnter);
            this.Label_Add_New_Reader.MouseLeave += new System.EventHandler(this.Label_Add_New_Reader_MouseLeave);
            // 
            // Form_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 691);
            this.Controls.Add(this.Panel_Head);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Borrow";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Head;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label Label_Next;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.Label Label_Reset_Search;
        private System.Windows.Forms.ComboBox Combo_Filter;
        private System.Windows.Forms.TextBox Text_Searchby;
        private System.Windows.Forms.Label Label_Filter;
        private System.Windows.Forms.Label Label_Book_Title;
        private System.Windows.Forms.Label Label_Add_New_Book;
        private System.Windows.Forms.Label Label_Add_New_Reader;
        private System.Windows.Forms.Label Label_View_Table_Books;
        private System.Windows.Forms.Label Label_View_Table_Readers;
        private System.Windows.Forms.DataGridView Datagrid_Table;
        private System.Windows.Forms.Label Label_Back;
    }
}