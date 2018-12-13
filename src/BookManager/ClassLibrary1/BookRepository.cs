using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDA.BookLibrary
{
    public class BookRepository
    {
        private static List<Book> _books = new List<Book>();
        private static int nextId = 0;

        public List<Book> ListAll()
        {
            return _books;
        }

        public Book GetById(int id)
        {
            return _books.Find(v => v.ID == id);
        }

        public void Add(Book newBook)
        {
            newBook.ID = nextId++;
            _books.Add(newBook);
        }
        public void Edit(Book editBook)
        {
            var origBook = GetById(editBook.ID);

            origBook.Year = editBook.Year;
            origBook.Title = editBook.Title;           
            origBook.Author = editBook.Author;
            
        }
        public void Delete(int id)
        {
            var bookToDelete = GetById(id);
            _books.Remove(bookToDelete);
        }
    }
}
