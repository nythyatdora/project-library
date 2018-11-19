using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public class User
    {
        private Int32 _id;
        private String _first_name;
        private String _last_name;
        private String _gender;
        private String _position;
        private String _email_address;
        private String _address;
        private String _phone_number;
        private String _user_name;
        private String _password;
        private DateTime _last_login;

        public Int32 ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public String First_Name
        {
            set { _first_name = value; }
            get { return _first_name; }
        }

        public String Last_Name
        {
            set { _last_name = value; }
            get { return _last_name; }
        }

        public String Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public String Position
        {
            set { _position = value; }
            get { return _position; }
        }

        public String Email_Address
        {
            set { _email_address = value; }
            get { return _email_address; }
        }

        public String Address
        {
            set { _address = value; }
            get { return _address; }
        }

        public String Phone_Number
        {
            set { _phone_number = value; }
            get { return _phone_number; }
        }

        public String User_Name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }

        public String Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public DateTime Last_Login
        {
            set { _last_login = value; }
            get { return _last_login; }
        }

    }
}
