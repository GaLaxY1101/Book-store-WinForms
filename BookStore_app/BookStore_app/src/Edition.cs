using BookStore_app;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BookStore_app
{
    
    public enum CoverTypes
    {
        Soft,
        Hard
    }

    [Serializable]
    public class Edition  // Видання
    {
        
        private String _name;

        private int _pagesCount;

        private int _yearOfPublishing;
        public Book Book { get; set; }
        
        public PublishingHouse PublishingHouse { get; set; }

        public CoverTypes TypeOfCover { get; set; }
        
        [XmlAttribute("Name")]
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Ви не вказали назву видання.");
                else _name = value;
            }
        }

        public int PagesCount
        {
            get
            {
                return _pagesCount;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Кількість сторінок має бути більшою за 0");
                else _pagesCount = value;
            }
        }

        public int YearOfPublishing
        {
            get
            {
                return _yearOfPublishing;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Рік видання не може бути < 0");
                else _yearOfPublishing = value;
            }
        }


        public Edition() { }
        public Edition(String name, int pagesCount, int yearOfPublishing, Book book,
                        PublishingHouse publishingHouse, CoverTypes typeOfCover)
        {
            this.Name = name;
            this.PagesCount = pagesCount;
            this.YearOfPublishing = yearOfPublishing;
            this.Book = book;
            this.PublishingHouse = publishingHouse;
            this.TypeOfCover = typeOfCover;
        }


    }
}
