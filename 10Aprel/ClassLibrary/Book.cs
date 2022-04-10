using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book
    {
        static int _totalCount { get; set; }
        public Book()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No { get; }
        public string Name { get; set; }
        
        public string AuthorName { get; set; }

        public TypeOfGenre Genre { get; set; }

        public double Price { get; set; }
    }
}
