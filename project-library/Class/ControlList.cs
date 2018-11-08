using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_library
{
    abstract class CustomObject {
        protected String object_name_;

        public String Obj_Name
        {
            set
            {
                object_name_ = value;
            }

            get
            {
                return object_name_;
            }
        }
    }

    class UserControlObject : CustomObject
    {
        private OverlapUserControl object_usercontrol_;

        public UserControlObject(String object_name, OverlapUserControl user_control)
        {
            object_name_ = object_name;
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
    
    class FormObject : CustomObject
    {
        private Form object_form_;

        public FormObject(String object_name, Form object_form)
        {
            object_name_ = object_name;
            object_form_ = object_form;
        }

        public Form Obj_Form
        {
            set
            {
                object_form_ = value;
            }

            get
            {
                return object_form_;
            }
        }
    }

    class UserControlList
    {
        private List<UserControlObject> list = new List<UserControlObject>();

        public void AddControl(UserControlObject item)
        {
            list.Add(item);
        }

        public OverlapUserControl this[String usercontrol_name]
        {
            get
            {
                for(int i=0; i<list.Count; i++)
                {
                    if(list[i].Obj_Name == usercontrol_name)
                    {
                        return list[i].Obj_UserControl;
                    }
                }
                return null;
            }
        }
    }

    class FormList
    {
        private List<FormObject> list = new List<FormObject>();

        public void AddControl(FormObject item)
        {
            list.Add(item);
        }

        public Form this[String form_name]
        {
            get
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Obj_Name == form_name)
                    {
                        return list[i].Obj_Form;
                    }
                }
                return null;
            }
        }
    }
}
