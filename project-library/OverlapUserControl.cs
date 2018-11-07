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
    public partial class OverlapUserControl : UserControl
    {
        private static OverlapUserControl _instance;

        public static OverlapUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OverlapUserControl();
                return _instance;
            }
        }
    }
}
