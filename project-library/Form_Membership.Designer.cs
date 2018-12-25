namespace project_library
{
    partial class Form_Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Membership));
            this.Panel_Head = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Confirm = new System.Windows.Forms.Label();
            this.Label_Reset = new System.Windows.Forms.Label();
            this.DatePicker_Expire_Date = new System.Windows.Forms.DateTimePicker();
            this.DatePicker_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.Combo_Member_Type = new System.Windows.Forms.ComboBox();
            this.Combo_Duration = new System.Windows.Forms.ComboBox();
            this.Label_View_Profile = new System.Windows.Forms.Label();
            this.Picbox_Reader_Picture = new System.Windows.Forms.PictureBox();
            this.Label_Expire_Date = new System.Windows.Forms.Label();
            this.Label_Start_Date = new System.Windows.Forms.Label();
            this.Label_Duration = new System.Windows.Forms.Label();
            this.Label_Member_Type = new System.Windows.Forms.Label();
            this.DatePicker_Date_of_Birth = new System.Windows.Forms.DateTimePicker();
            this.Label_Date_of_Birth = new System.Windows.Forms.Label();
            this.Text_Full_Name = new System.Windows.Forms.TextBox();
            this.Label_Full_Name = new System.Windows.Forms.Label();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Label_Reset_Search = new System.Windows.Forms.Label();
            this.Combo_Filter = new System.Windows.Forms.ComboBox();
            this.Text_Searchby = new System.Windows.Forms.TextBox();
            this.Label_Filter = new System.Windows.Forms.Label();
            this.Label_Book_Title = new System.Windows.Forms.Label();
            this.Label_New_Reader = new System.Windows.Forms.Label();
            this.Label_View_Table_Readers = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Reader_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Head
            // 
            this.Panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(102)))), ((int)(((byte)(24)))));
            this.Panel_Head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Head.Location = new System.Drawing.Point(0, 0);
            this.Panel_Head.Name = "Panel_Head";
            this.Panel_Head.Size = new System.Drawing.Size(900, 15);
            this.Panel_Head.TabIndex = 1;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Body.Controls.Add(this.Label_Title);
            this.Panel_Body.Controls.Add(this.Label_Close);
            this.Panel_Body.Controls.Add(this.Label_Confirm);
            this.Panel_Body.Controls.Add(this.Label_Reset);
            this.Panel_Body.Controls.Add(this.DatePicker_Expire_Date);
            this.Panel_Body.Controls.Add(this.DatePicker_Start_Date);
            this.Panel_Body.Controls.Add(this.Combo_Member_Type);
            this.Panel_Body.Controls.Add(this.Combo_Duration);
            this.Panel_Body.Controls.Add(this.Label_View_Profile);
            this.Panel_Body.Controls.Add(this.Picbox_Reader_Picture);
            this.Panel_Body.Controls.Add(this.Label_Expire_Date);
            this.Panel_Body.Controls.Add(this.Label_Start_Date);
            this.Panel_Body.Controls.Add(this.Label_Duration);
            this.Panel_Body.Controls.Add(this.Label_Member_Type);
            this.Panel_Body.Controls.Add(this.DatePicker_Date_of_Birth);
            this.Panel_Body.Controls.Add(this.Label_Date_of_Birth);
            this.Panel_Body.Controls.Add(this.Text_Full_Name);
            this.Panel_Body.Controls.Add(this.Label_Full_Name);
            this.Panel_Body.Controls.Add(this.Label_Search);
            this.Panel_Body.Controls.Add(this.Label_Reset_Search);
            this.Panel_Body.Controls.Add(this.Combo_Filter);
            this.Panel_Body.Controls.Add(this.Text_Searchby);
            this.Panel_Body.Controls.Add(this.Label_Filter);
            this.Panel_Body.Controls.Add(this.Label_Book_Title);
            this.Panel_Body.Controls.Add(this.Label_New_Reader);
            this.Panel_Body.Controls.Add(this.Label_View_Table_Readers);
            this.Panel_Body.Location = new System.Drawing.Point(0, 15);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(900, 695);
            this.Panel_Body.TabIndex = 2;
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
            // Label_Confirm
            // 
            this.Label_Confirm.AutoSize = true;
            this.Label_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Label_Confirm.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Confirm.ForeColor = System.Drawing.Color.White;
            this.Label_Confirm.Location = new System.Drawing.Point(775, 626);
            this.Label_Confirm.Name = "Label_Confirm";
            this.Label_Confirm.Size = new System.Drawing.Size(90, 23);
            this.Label_Confirm.TabIndex = 75;
            this.Label_Confirm.Text = "CONFIRM";
            this.Label_Confirm.Click += new System.EventHandler(this.Label_Confirm_Click);
            this.Label_Confirm.MouseEnter += new System.EventHandler(this.Label_Confirm_MouseEnter);
            this.Label_Confirm.MouseLeave += new System.EventHandler(this.Label_Confirm_MouseLeave);
            // 
            // Label_Reset
            // 
            this.Label_Reset.AutoSize = true;
            this.Label_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Label_Reset.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reset.ForeColor = System.Drawing.Color.White;
            this.Label_Reset.Location = new System.Drawing.Point(273, 626);
            this.Label_Reset.Name = "Label_Reset";
            this.Label_Reset.Size = new System.Drawing.Size(65, 23);
            this.Label_Reset.TabIndex = 74;
            this.Label_Reset.Text = "RESET";
            this.Label_Reset.MouseEnter += new System.EventHandler(this.Label_Reset_MouseEnter);
            this.Label_Reset.MouseLeave += new System.EventHandler(this.Label_Reset_MouseLeave);
            // 
            // DatePicker_Expire_Date
            // 
            this.DatePicker_Expire_Date.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.DatePicker_Expire_Date.Location = new System.Drawing.Point(585, 569);
            this.DatePicker_Expire_Date.Name = "DatePicker_Expire_Date";
            this.DatePicker_Expire_Date.Size = new System.Drawing.Size(280, 33);
            this.DatePicker_Expire_Date.TabIndex = 73;
            // 
            // DatePicker_Start_Date
            // 
            this.DatePicker_Start_Date.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.DatePicker_Start_Date.Location = new System.Drawing.Point(277, 569);
            this.DatePicker_Start_Date.Name = "DatePicker_Start_Date";
            this.DatePicker_Start_Date.Size = new System.Drawing.Size(280, 33);
            this.DatePicker_Start_Date.TabIndex = 72;
            // 
            // Combo_Member_Type
            // 
            this.Combo_Member_Type.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.Combo_Member_Type.FormattingEnabled = true;
            this.Combo_Member_Type.Location = new System.Drawing.Point(585, 477);
            this.Combo_Member_Type.Name = "Combo_Member_Type";
            this.Combo_Member_Type.Size = new System.Drawing.Size(280, 33);
            this.Combo_Member_Type.TabIndex = 71;
            // 
            // Combo_Duration
            // 
            this.Combo_Duration.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.Combo_Duration.FormattingEnabled = true;
            this.Combo_Duration.Location = new System.Drawing.Point(277, 477);
            this.Combo_Duration.Name = "Combo_Duration";
            this.Combo_Duration.Size = new System.Drawing.Size(280, 33);
            this.Combo_Duration.TabIndex = 70;
            // 
            // Label_View_Profile
            // 
            this.Label_View_Profile.AutoSize = true;
            this.Label_View_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Label_View_Profile.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View_Profile.ForeColor = System.Drawing.Color.White;
            this.Label_View_Profile.Location = new System.Drawing.Point(90, 569);
            this.Label_View_Profile.Name = "Label_View_Profile";
            this.Label_View_Profile.Size = new System.Drawing.Size(108, 23);
            this.Label_View_Profile.TabIndex = 69;
            this.Label_View_Profile.Text = "view profile";
            this.Label_View_Profile.MouseEnter += new System.EventHandler(this.Label_View_Profile_MouseEnter);
            this.Label_View_Profile.MouseLeave += new System.EventHandler(this.Label_View_Profile_MouseLeave);
            // 
            // Picbox_Reader_Picture
            // 
            this.Picbox_Reader_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picbox_Reader_Picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picbox_Reader_Picture.BackgroundImage")));
            this.Picbox_Reader_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picbox_Reader_Picture.Location = new System.Drawing.Point(37, 341);
            this.Picbox_Reader_Picture.Name = "Picbox_Reader_Picture";
            this.Picbox_Reader_Picture.Size = new System.Drawing.Size(219, 219);
            this.Picbox_Reader_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picbox_Reader_Picture.TabIndex = 68;
            this.Picbox_Reader_Picture.TabStop = false;
            // 
            // Label_Expire_Date
            // 
            this.Label_Expire_Date.AutoSize = true;
            this.Label_Expire_Date.BackColor = System.Drawing.Color.Transparent;
            this.Label_Expire_Date.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Expire_Date.ForeColor = System.Drawing.Color.White;
            this.Label_Expire_Date.Location = new System.Drawing.Point(579, 533);
            this.Label_Expire_Date.Name = "Label_Expire_Date";
            this.Label_Expire_Date.Size = new System.Drawing.Size(153, 33);
            this.Label_Expire_Date.TabIndex = 66;
            this.Label_Expire_Date.Text = "Expire Date";
            // 
            // Label_Start_Date
            // 
            this.Label_Start_Date.AutoSize = true;
            this.Label_Start_Date.BackColor = System.Drawing.Color.Transparent;
            this.Label_Start_Date.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Start_Date.ForeColor = System.Drawing.Color.White;
            this.Label_Start_Date.Location = new System.Drawing.Point(271, 533);
            this.Label_Start_Date.Name = "Label_Start_Date";
            this.Label_Start_Date.Size = new System.Drawing.Size(136, 33);
            this.Label_Start_Date.TabIndex = 64;
            this.Label_Start_Date.Text = "Start Date";
            // 
            // Label_Duration
            // 
            this.Label_Duration.AutoSize = true;
            this.Label_Duration.BackColor = System.Drawing.Color.Transparent;
            this.Label_Duration.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Duration.ForeColor = System.Drawing.Color.White;
            this.Label_Duration.Location = new System.Drawing.Point(271, 441);
            this.Label_Duration.Name = "Label_Duration";
            this.Label_Duration.Size = new System.Drawing.Size(120, 33);
            this.Label_Duration.TabIndex = 62;
            this.Label_Duration.Text = "Duration";
            // 
            // Label_Member_Type
            // 
            this.Label_Member_Type.AutoSize = true;
            this.Label_Member_Type.BackColor = System.Drawing.Color.Transparent;
            this.Label_Member_Type.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Member_Type.ForeColor = System.Drawing.Color.White;
            this.Label_Member_Type.Location = new System.Drawing.Point(579, 441);
            this.Label_Member_Type.Name = "Label_Member_Type";
            this.Label_Member_Type.Size = new System.Drawing.Size(173, 33);
            this.Label_Member_Type.TabIndex = 60;
            this.Label_Member_Type.Text = "Member Type";
            // 
            // DatePicker_Date_of_Birth
            // 
            this.DatePicker_Date_of_Birth.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.DatePicker_Date_of_Birth.Location = new System.Drawing.Point(585, 375);
            this.DatePicker_Date_of_Birth.Name = "DatePicker_Date_of_Birth";
            this.DatePicker_Date_of_Birth.Size = new System.Drawing.Size(280, 33);
            this.DatePicker_Date_of_Birth.TabIndex = 59;
            // 
            // Label_Date_of_Birth
            // 
            this.Label_Date_of_Birth.AutoSize = true;
            this.Label_Date_of_Birth.BackColor = System.Drawing.Color.Transparent;
            this.Label_Date_of_Birth.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Date_of_Birth.ForeColor = System.Drawing.Color.White;
            this.Label_Date_of_Birth.Location = new System.Drawing.Point(579, 339);
            this.Label_Date_of_Birth.Name = "Label_Date_of_Birth";
            this.Label_Date_of_Birth.Size = new System.Drawing.Size(164, 33);
            this.Label_Date_of_Birth.TabIndex = 58;
            this.Label_Date_of_Birth.Text = "Date of Birth";
            // 
            // Text_Full_Name
            // 
            this.Text_Full_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Full_Name.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Full_Name.Location = new System.Drawing.Point(277, 375);
            this.Text_Full_Name.Name = "Text_Full_Name";
            this.Text_Full_Name.Size = new System.Drawing.Size(280, 33);
            this.Text_Full_Name.TabIndex = 57;
            // 
            // Label_Full_Name
            // 
            this.Label_Full_Name.AutoSize = true;
            this.Label_Full_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Full_Name.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Full_Name.ForeColor = System.Drawing.Color.White;
            this.Label_Full_Name.Location = new System.Drawing.Point(271, 339);
            this.Label_Full_Name.Name = "Label_Full_Name";
            this.Label_Full_Name.Size = new System.Drawing.Size(136, 33);
            this.Label_Full_Name.TabIndex = 56;
            this.Label_Full_Name.Text = "Full Name";
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
            this.Label_Search.Click += new System.EventHandler(this.Label_Search_Click);
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
            // Label_New_Reader
            // 
            this.Label_New_Reader.AutoSize = true;
            this.Label_New_Reader.BackColor = System.Drawing.Color.Transparent;
            this.Label_New_Reader.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_New_Reader.ForeColor = System.Drawing.Color.White;
            this.Label_New_Reader.Location = new System.Drawing.Point(768, 91);
            this.Label_New_Reader.Name = "Label_New_Reader";
            this.Label_New_Reader.Size = new System.Drawing.Size(105, 46);
            this.Label_New_Reader.TabIndex = 3;
            this.Label_New_Reader.Text = "add\r\nnew reader\r\n";
            this.Label_New_Reader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_New_Reader.Click += new System.EventHandler(this.Label_New_Reader_Click);
            this.Label_New_Reader.MouseEnter += new System.EventHandler(this.Label_New_Reader_MouseEnter);
            this.Label_New_Reader.MouseLeave += new System.EventHandler(this.Label_New_Reader_MouseLeave);
            // 
            // Label_View_Table_Readers
            // 
            this.Label_View_Table_Readers.AutoSize = true;
            this.Label_View_Table_Readers.BackColor = System.Drawing.Color.Transparent;
            this.Label_View_Table_Readers.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View_Table_Readers.ForeColor = System.Drawing.Color.White;
            this.Label_View_Table_Readers.Location = new System.Drawing.Point(752, 31);
            this.Label_View_Table_Readers.Name = "Label_View_Table_Readers";
            this.Label_View_Table_Readers.Size = new System.Drawing.Size(121, 46);
            this.Label_View_Table_Readers.TabIndex = 2;
            this.Label_View_Table_Readers.Text = "view\r\ntable readers";
            this.Label_View_Table_Readers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_View_Table_Readers.Click += new System.EventHandler(this.Label_View_Table_Readers_Click);
            this.Label_View_Table_Readers.MouseEnter += new System.EventHandler(this.Label_View_Table_Readers_MouseEnter);
            this.Label_View_Table_Readers.MouseLeave += new System.EventHandler(this.Label_View_Table_Readers_MouseLeave);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Bahnschrift", 56F);
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(22, 47);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(454, 90);
            this.Label_Title.TabIndex = 106;
            this.Label_Title.Text = "Membership";
            // 
            // Form_Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 695);
            this.Controls.Add(this.Panel_Head);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Membership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Membership";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Reader_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Head;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_New_Reader;
        private System.Windows.Forms.Label Label_View_Table_Readers;
        private System.Windows.Forms.ComboBox Combo_Filter;
        private System.Windows.Forms.TextBox Text_Searchby;
        private System.Windows.Forms.Label Label_Filter;
        private System.Windows.Forms.Label Label_Book_Title;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.Label Label_Reset_Search;
        private System.Windows.Forms.TextBox Text_Full_Name;
        private System.Windows.Forms.Label Label_Full_Name;
        private System.Windows.Forms.Label Label_Expire_Date;
        private System.Windows.Forms.Label Label_Start_Date;
        private System.Windows.Forms.Label Label_Duration;
        private System.Windows.Forms.Label Label_Member_Type;
        private System.Windows.Forms.DateTimePicker DatePicker_Date_of_Birth;
        private System.Windows.Forms.Label Label_Date_of_Birth;
        private System.Windows.Forms.Label Label_View_Profile;
        private System.Windows.Forms.PictureBox Picbox_Reader_Picture;
        private System.Windows.Forms.DateTimePicker DatePicker_Expire_Date;
        private System.Windows.Forms.DateTimePicker DatePicker_Start_Date;
        private System.Windows.Forms.ComboBox Combo_Member_Type;
        private System.Windows.Forms.ComboBox Combo_Duration;
        private System.Windows.Forms.Label Label_Confirm;
        private System.Windows.Forms.Label Label_Reset;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label Label_Title;
    }
}