﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_library.Class
{
    public class FormBook
    {
        Int64 id_;
        String book_title_;
        String author_;
        String publisher_;
        String language_;
        String paperback_;
        Double price_;
        Int64 quantity_;
        String isbn10_;
        String isbn13_;
        String description_;
        String location_bookcover_;
        public FormBook(Int64 id, String book_title, String author, String publisher, String language, String paperback, Double price, Int64 quantity, String isbn10, String isbn13, String description, String location_bookcover)
        {
            id_ = id;
            book_title_ = book_title;
            author_ = author;
            publisher_ = publisher;
            language_ = language;
            paperback_ = paperback;
            price_ = price;
            quantity_ = quantity;
            isbn10_ = isbn10;
            isbn13_ = isbn13;
            description_ = description;
            location_bookcover_ = location_bookcover;
        }
        public Int64 ID
        {
            set { id_ = value; }
            get { return id_; }
        }
        public String Book_Title
        {
            set { book_title_ = value; }
            get { return book_title_; }
        }
        public String Author
        {
            set { author_ = value; }
            get { return author_; }
        }
        public String Publisher
        {
            set { publisher_ = value; }
            get { return publisher_; }
        }
        public String Language
        {
            set { language_ = value; }
            get { return language_; }
        }
        public String Paperback
        {
            set { paperback_ = value; }
            get { return paperback_; }
        }
        public Double Price
        {
            set { price_ = value; }
            get { return price_; }
        }
        public Int64 Quantity
        {
            set { quantity_ = value; }
            get { return quantity_; }
        }
        public String ISBN10
        {
            set { isbn10_ = value; }
            get { return isbn10_; }
        }
        public String ISBN13
        {
            set { isbn13_ = value; }
            get { return isbn13_; }
        }
        public String Description
        {
            set { description_ = value; }
            get { return description_; }
        }
        public String Location_Bookcover
        {
            set { location_bookcover_ = value; }
            get { return location_bookcover_; }
        }
    }
}