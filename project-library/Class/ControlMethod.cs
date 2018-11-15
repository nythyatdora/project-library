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
        public static void SetFormOnPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            panel.Controls.Clear();

            if (!panel.Controls.Contains(form))
            {
                panel.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Show();
            }
        }

        public static void LoadForm(Form form)
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
