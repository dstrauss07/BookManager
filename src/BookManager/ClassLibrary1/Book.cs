using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDA.BookLibrary
{
    public class Book
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string GetFullName()
        {
            return $"{Year} {Title} by {Author}";
        }
    }
}
