using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public abstract class CustomObject
    {
        protected String _object_name;

        public String Obj_Name
        {
            set
            {
                _object_name = value;
            }

            get
            {
                return _object_name;
            }
        }
    }
}
