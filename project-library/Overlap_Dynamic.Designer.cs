namespace project_library
{
    partial class Overlap_Dynamic
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
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Button_Home = new System.Windows.Forms.Button();
            this.Button_Borrow_Return = new System.Windows.Forms.Button();
            this.Button_Books = new System.Windows.Forms.Button();
            this.Button_Membership = new System.Windows.Forms.Button();
            this.Button_Readers = new System.Windows.Forms.Button();
            this.Button_Category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.Location = new System.Drawing.Point(151, 18);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(852, 579);
            this.Panel_Main.TabIndex = 0;
            // 
            // Button_Home
            // 
            this.Button_Home.Location = new System.Drawing.Point(12, 18);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(131, 39);
            this.Button_Home.TabIndex = 1;
            this.Button_Home.Text = "HOME";
            this.Button_Home.UseVisualStyleBackColor = true;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Button_Borrow_Return
            // 
            this.Button_Borrow_Return.Location = new System.Drawing.Point(12, 63);
            this.Button_Borrow_Return.Name = "Button_Borrow_Return";
            this.Button_Borrow_Return.Size = new System.Drawing.Size(131, 39);
            this.Button_Borrow_Return.TabIndex = 2;
            this.Button_Borrow_Return.Text = "BORROW/RETURN";
            this.Button_Borrow_Return.UseVisualStyleBackColor = true;
            this.Button_Borrow_Return.Click += new System.EventHandler(this.Button_Borrow_Return_Click);
            // 
            // Button_Books
            // 
            this.Button_Books.Location = new System.Drawing.Point(12, 108);
            this.Button_Books.Name = "Button_Books";
            this.Button_Books.Size = new System.Drawing.Size(131, 39);
            this.Button_Books.TabIndex = 3;
            this.Button_Books.Text = "BOOKS";
            this.Button_Books.UseVisualStyleBackColor = true;
            this.Button_Books.Click += new System.EventHandler(this.Button_Books_Click);
            // 
            // Button_Membership
            // 
            this.Button_Membership.Location = new System.Drawing.Point(12, 243);
            this.Button_Membership.Name = "Button_Membership";
            this.Button_Membership.Size = new System.Drawing.Size(131, 39);
            this.Button_Membership.TabIndex = 6;
            this.Button_Membership.Text = "MEMBERSHIP";
            this.Button_Membership.UseVisualStyleBackColor = true;
            // 
            // Button_Readers
            // 
            this.Button_Readers.Location = new System.Drawing.Point(12, 198);
            this.Button_Readers.Name = "Button_Readers";
            this.Button_Readers.Size = new System.Drawing.Size(131, 39);
            this.Button_Readers.TabIndex = 5;
            this.Button_Readers.Text = "READERS";
            this.Button_Readers.UseVisualStyleBackColor = true;
            this.Button_Readers.Click += new System.EventHandler(this.Button_Readers_Click);
            // 
            // Button_Category
            // 
            this.Button_Category.Location = new System.Drawing.Point(12, 153);
            this.Button_Category.Name = "Button_Category";
            this.Button_Category.Size = new System.Drawing.Size(131, 39);
            this.Button_Category.TabIndex = 4;
            this.Button_Category.Text = "CATEGORY";
            this.Button_Category.UseVisualStyleBackColor = true;
            this.Button_Category.Click += new System.EventHandler(this.Button_Category_Click);
            // 
            // Overlap_Dynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.Button_Membership);
            this.Controls.Add(this.Button_Readers);
            this.Controls.Add(this.Button_Category);
            this.Controls.Add(this.Button_Books);
            this.Controls.Add(this.Button_Borrow_Return);
            this.Controls.Add(this.Button_Home);
            this.Controls.Add(this.Panel_Main);
            this.Name = "Overlap_Dynamic";
            this.Text = "Overlap_Dynamic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Button_Home;
        private System.Windows.Forms.Button Button_Borrow_Return;
        private System.Windows.Forms.Button Button_Books;
        private System.Windows.Forms.Button Button_Membership;
        private System.Windows.Forms.Button Button_Readers;
        private System.Windows.Forms.Button Button_Category;
    }
}