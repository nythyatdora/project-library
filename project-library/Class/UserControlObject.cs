using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_library.Class;

namespace project_library.Class
{
    public class UserControlObject : CustomObject
    {
        protected OverlapUserControl _object_usercontrol;

        public UserControlObject(String object_name, OverlapUserControl user_control)
        {
            _object_name = object_name;
            _object_usercontrol = user_control;
        }

        public OverlapUserControl Obj_UserControl
        {
            set
            {
                _object_usercontrol = value;
            }

            get
            {
                return _object_usercontrol;
            }
        }
    }
}
