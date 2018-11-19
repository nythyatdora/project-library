using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public class Reader
    {
        private Int32 _id;
        private String _first_name;
        private String _last_name;
        private Char _gender;
        private DateTime _date_of_birth;
        private String _occupation;
        private String _organization;
        private String _phone_number;
        private String _email_address;
        private String _address;
        private String _location_picture;
        private String _location_identification;
        private Int32 _membership_duration;
        private String _membership_type;
        private DateTime _membership_startdate;
        private DateTime _membership_expiredate;
        
        public Reader(String first_name, String last_name, Char gender, DateTime date_of_birth, String occupation, String organization, String phone_number, String email_address, String address, String location_picture, String location_identification, Int32 membership_duration, String membership_type, DateTime membership_startdate, DateTime membership_expiredate)
        {
            _first_name = first_name;
            _last_name = last_name;
            _gender = gender;
            _date_of_birth = date_of_birth;
            _occupation = occupation;
            _organization = organization;
            _phone_number = phone_number;
            _email_address = email_address;
            _address = address;
            _location_picture = location_picture;
            _location_identification = location_identification;
            _membership_duration = membership_duration;
            _membership_type = membership_type;
            _membership_startdate = membership_startdate;
            _membership_expiredate = membership_expiredate;
        }

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

        public Char Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public DateTime Date_of_Birth
        {
            set { _date_of_birth = value; }
            get { return _date_of_birth; }
        }

        public String Occupation
        {
            set { _occupation = value; }
            get { return _occupation; }
        }

        public String Organization
        {
            set { _organization = value; }
            get { return _organization; }
        }

        public String Phone_Number
        {
            set { _phone_number = value; }
            get { return _phone_number; }
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

        public String Location_Picture
        {
            set { _location_picture = value; }
            get { return _location_picture; }
        }

        public String Location_Identification
        {
            set { _location_identification = value; }
            get { return _location_identification; }
        }

        public Int32 Membership_Duration
        {
            set { _membership_duration = value; }
            get { return _membership_duration; }
        }

        public String Membership_Type
        {
            set { _membership_type = value; }
            get { return _membership_type; }
        }

        public DateTime Membership_Startdate
        {
            set { _membership_startdate = value; }
            get { return _membership_startdate; }
        }
        
        public DateTime Membership_Expiredate
        {
            set { _membership_expiredate = value; }
            get { return _membership_expiredate; }
        }
    }
}
