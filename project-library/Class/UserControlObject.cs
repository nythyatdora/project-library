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
        protected OverlapUserControl object_usercontrol_;

        public UserControlObject(String object_name, OverlapUserControl user_control)
        {
            _object_name = object_name;
            object_usercontrol_ = user_control;
        }

        public OverlapUserControl Obj_UserControl
        {
            set
            {
                object_usercontrol_ = value;
            }

            get
            {
                return object_usercontrol_;
            }
        }
    }
}
