using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library
{
    public partial class CustomForm : Form
    {
        private static CustomForm _instance;

        public static CustomForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomForm();
                return _instance;
            }
        }
    }
}
