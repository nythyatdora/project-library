using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library.Class
{
    class ControlMethod
    {
        public static void SetUserControlOnPanel(Panel panel, OverlapUserControl overlap)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(overlap))
            {
                panel.Controls.Add(overlap);
                overlap.Dock = DockStyle.Fill;
                overlap.BringToFront();
            }
            else
            {
                overlap.BringToFront();
            }
        }

        public static void SetFormLoad(Form form)
        {
            form.Show();
        }

        public static void SetTextboxEmpty(Form form)
        {
            foreach(Control control in form.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Textbox")
                {
                    control.Text = "";
                }
            }
        }
    }
}
