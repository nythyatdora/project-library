using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public class FormReader
    {
        private Int32 id_;
        private String first_name_;
        private String last_name_;
        private Char gender_;
        private DateTime date_of_birth_;
        private String occupation_;
        private String organization_;
        private String phone_number_;
        private String email_address_;
        private String address_;
        private String location_picture_;
        private String location_identification_;
        private Int32 membership_duration_;
        private String membership_type_;
        private DateTime membership_startdate_;
        private DateTime membership_expiredate_;
        
        public FormReader(String first_name, String last_name, Char gender, DateTime date_of_birth, String occupation, String organization, String phone_number, String email_address, String address, String location_picture, String location_identification, Int32 membership_duration, String membership_type, DateTime membership_startdate, DateTime membership_expiredate)
        {
            first_name_ = first_name;
            last_name_ = last_name;
            gender_ = gender;
            date_of_birth_ = date_of_birth;
            occupation_ = occupation;
            organization_ = organization;
            phone_number_ = phone_number;
            email_address_ = email_address;
            address_ = address;
            location_picture_ = location_picture;
            location_identification_ = location_identification;
            membership_duration_ = membership_duration;
            membership_type_ = membership_type;
            membership_startdate_ = membership_startdate;
            membership_expiredate_ = membership_expiredate;
        }

        public Int32 ID
        {
            set { id_ = value; }
            get { return id_; }
        }

        public String First_Name
        {
            set { first_name_ = value; }
            get { return first_name_; }
        }

        public String Last_Name
        {
            set { last_name_ = value; }
            get { return last_name_; }
        }

        public Char Gender
        {
            set { gender_ = value; }
            get { return gender_; }
        }

        public DateTime Date_of_Birth
        {
            set { date_of_birth_ = value; }
            get { return date_of_birth_; }
        }

        public String Occupation
        {
            set { occupation_ = value; }
            get { return occupation_; }
        }

        public String Organization
        {
            set { organization_ = value; }
            get { return organization_; }
        }

        public String Phone_Number
        {
            set { phone_number_ = value; }
            get { return phone_number_; }
        }

        public String Email_Address
        {
            set { email_address_ = value; }
            get { return email_address_; }
        }

        public String Address
        {
            set { address_ = value; }
            get { return address_; }
        }

        public String Location_Picture
        {
            set { location_picture_ = value; }
            get { return location_picture_; }
        }

        public String Location_Identification
        {
            set { location_identification_ = value; }
            get { return location_identification_; }
        }

        public Int32 Membership_Duration
        {
            set { membership_duration_ = value; }
            get { return membership_duration_; }
        }

        public String Membership_Type
        {
            set { membership_type_ = value; }
            get { return membership_type_; }
        }

        public DateTime Membership_Startdate
        {
            set { membership_startdate_ = value; }
            get { return membership_startdate_; }
        }
        
        public DateTime Membership_Expiredate
        {
            set { membership_expiredate_ = value; }
            get { return membership_expiredate_; }
        }
    }
}
