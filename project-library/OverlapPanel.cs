using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library
{
    public partial class OverlapPanel : Form
    {
        List<Panel> panels = new List<Panel>();

        public OverlapPanel()
        {
            InitializeComponent();

            panels.Add(panel_home);
            panels.Add(panel_books);
        }

        private void OverlapPanel_Load(object sender, EventArgs e)
        {

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
        }
    }
}
