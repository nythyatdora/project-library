﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_library.Class;

namespace project_library
{
    class FormList
    {
        private List<FormObject> list = new List<FormObject>();

        public void AddForm(FormObject item)
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
