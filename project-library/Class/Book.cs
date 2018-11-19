using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public class Book
    {
        private Int32 _id;
        private String _book_title;
        private String _author;
        private String _publisher_;
        private String _language;
        private String _paperback;
        private Double _price;
        private Int32 _quantity;
        private String _isbn10;
        private String _isbn13;
        private String _description;
        private String _location_bookcover;

        public Book(String book_title, String author, String _publisher, String language, String paperback, 
                        Double price, Int32 quantity, String isbn10, String isbn13, String description, String location_bookcover)
        {
            _book_title = book_title;
            _author = author;
            _publisher_ = _publisher;
            _language = language;
            _paperback = paperback;
            _price = price;
            _quantity = quantity;
            _isbn10 = isbn10;
            _isbn13 = isbn13;
            _description = description;
            _location_bookcover = location_bookcover;
        }

        public Int32 ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public String Book_Title
        {
            set { _book_title = value; }
            get { return _book_title; }
        }

        public String Author
        {
            set { _author = value; }
            get { return _author; }
        }

        public String Publisher
        {
            set { _publisher_ = value; }
            get { return _publisher_; }
        }

        public String Language
        {
            set { _language = value; }
            get { return _language; }
        }

        public String Paperback
        {
            set { _paperback = value; }
            get { return _paperback; }
        }

        public Double Price
        {
            set { _price = value; }
            get { return _price; }
        }

        public Int32 Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        public String ISBN10
        {
            set { _isbn10 = value; }
            get { return _isbn10; }
        }

        public String ISBN13
        {
            set { _isbn13 = value; }
            get { return _isbn13; }
        }

        public String Description
        {
            set { _description = value; }
            get { return _description; }
        }

        public String Location_Bookcover
        {
            set { _location_bookcover = value; }
            get { return _location_bookcover; }
        }
    }
}