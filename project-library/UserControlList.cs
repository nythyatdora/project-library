using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library
{
    class CustomUserControl
    {
        private String usercontrol_name_;
        private OverlapUserControl obj_usercontrol_;

        public CustomUserControl()
        {

        }

        public CustomUserControl(String user_control_title, OverlapUserControl user_control)
        {
            usercontrol_name_ = user_control_title;
            obj_usercontrol_ = user_control;
        }

        public String UserControl_Name
        {
            set
            {
                usercontrol_name_ = value;
            }

            get
            {
                return usercontrol_name_;
            }
        }

        public OverlapUserControl Obj_User_Control
        {
            set
            {
                obj_usercontrol_ = value;
            }

            get
            {
                return obj_usercontrol_;
            }
        }
        
    }

    class UserControlList
    {
        private List<CustomUserControl> list = new List<CustomUserControl>();

        public void AddControl(CustomUserControl item)
        {
            list.Add(item);
        }

        public OverlapUserControl this[String usercontrol_title]
        {
            get
            {
                for(int i=0; i<list.Count; i++)
                {
                    if(list[i].UserControl_Name == usercontrol_title)
                    {
                        return list[i].Obj_User_Control;
                    }
                }
                return null;
            }
        }
    }


}
