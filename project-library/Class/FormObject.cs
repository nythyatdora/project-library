using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library.Class
{
    class FormObject : CustomObject
    {
        private Form _object_form;

        public FormObject(String object_name, Form object_form)
        {
            _object_name = object_name;
            _object_form = object_form;
        }

        public Form Obj_Form
        {
            set
            {
                _object_form = value;
            }

            get
            {
                return _object_form;
            }
        }
    }
}
