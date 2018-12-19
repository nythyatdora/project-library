using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_library.Class;

namespace project_library
{
    public partial class Form_Main : Form
    {
        private FormList List_Forms = new FormList();

        public Form_Main()
        {
            InitializeComponent();

            List_Forms.AddForm(new FormObject("Form_Home", new Form_Home(this)));
            List_Forms.AddForm(new FormObject("Form_Borrow_Return", new Form_Borrow_Return()));
            List_Forms.AddForm(new FormObject("Form_Books", new Form_Books()));
            List_Forms.AddForm(new FormObject("Form_Category", new Form_Category()));
            List_Forms.AddForm(new FormObject("Form_Readers", new Form_Readers()));
            List_Forms.AddForm(new FormObject("Form_Myprofile", new Form_MyProfile_One()));

            //List_Forms.AddForm(new FormObject("Form_Borrow", new Form_Borrow(this)));
            //List_Forms.AddForm(new FormObject("Form_Return", new Form_Return()));
            //List_Forms.AddForm(new FormObject("Form_Membership", new Form_Membership(this)));
            //List_Forms.AddForm(new FormObject("Form_Insert_Reader", new Form_Insert_Reader(this)));
            //List_Forms.AddForm(new FormObject("Form_Insert_Book", new Form_Insert_Book(this)));
            //List_Forms.AddForm(new FormObject("Form_Table_Readers", new Form_Table("Readers")));
            //List_Forms.AddForm(new FormObject("Form_Import_Text", new Form_Import_Text()));
            //List_Forms.AddForm(new FormObject("Form_Table_Books", new Form_Table("Books")));
            //List_Forms.AddForm(new FormObject("Form_Search", new Form_Search()));
        }

        public Form GetForm(String str)
        {
            return List_Forms[str];
        }

        private void Label_Dropmenu_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Dropmenu);
        }

        private void Label_Dropmenu_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Dropmenu);
        }

        private void Label_Home_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Home);
        }

        private void Label_Home_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Home);
        }

        private void Label_Borrow_Return_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Borrow_Return);
        }

        private void Label_Borrow_Return_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Borrow_Return);
        }

        private void Label_Books_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Books);
        }

        private void Label_Books_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Books);
        }

        private void Label_Category_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Category);
        }

        private void Label_Category_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Category);
        }

        private void Label_Readers_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Readers);
        }

        private void Label_Readers_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Readers);
        }

        private void Label_Membership_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Membership);
        }

        private void Label_Membership_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Membership);
        }

        private void Label_Myprofile_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Myprofile);
        }

        private void Label_Myprofile_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Myprofile);
        }

        private void Label_Report_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Report);
        }

        private void Label_Report_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Report);
        }

        private void Label_Exit_MouseEnter(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelGreen(Label_Exit);
        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            GraphicInteraction.SetColorLabelWhite(Label_Exit);
        }

        private void Label_Dropmenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label_Dropmenu.ContextMenuStrip = ContextMenuStrip_Main;
                Label_Dropmenu.ContextMenuStrip.Show(Label_Dropmenu,5,25);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main,List_Forms["Form_Home"]);
        }

        private void Label_Home_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Home"]);
        }

        private void Label_Borrow_Return_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Borrow_Return"]);
        }

        private void Label_Books_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Books"]);
        }

        private void Label_Category_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Category"]);
        }

        private void Label_Readers_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Readers"]);
        }

        private void Label_Membership_Click(object sender, EventArgs e)
        {
            //ControlMethod.LoadForm(List_Forms["Form_Membership"]);
            ControlMethod.LoadForm(new Form_Membership());
        }

        private void Label_Myprofile_Click(object sender, EventArgs e)
        {
            ControlMethod.SetFormOnPanel(Panel_Main, List_Forms["Form_Myprofile"]);
        }

        private void Label_Report_Click(object sender, EventArgs e)
        {

        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Borrow"));
        }

        private void TableBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Books"));
        }

        private void TableReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Readers"));
        }

        private void TableMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Membership"));
        }

        private void TableLoginHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Login History"));
        }

        private void ScienceFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Science Fiction"));
        }

        private void DramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Drama"));
        }

        private void MysteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Mystery"));
        }

        private void ComicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Comics"));
        }

        private void MathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Math"));
        }

        private void HorrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Horror"));
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("History"));
        }

        private void FantasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Fantasy"));
        }

        private void AdventureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Adventure"));
        }

        private void ScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Science"));
        }

        private void tableProceedBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMethod.LoadForm(new Form_Table("Proceed Borrow"));
        }
    }
}
