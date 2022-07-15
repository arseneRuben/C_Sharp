using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
        private List<Book> books;
        
        public String Name
        {
            get; set;
        }

        public Library(List<Book> l)
        {
            this.books = l;
        }

        public List<Book> Books
        {
            get; set;
        }
        public Library(List<Book> l, string name)
        {
            this.books = l;
            this.Name = name;
        }

        public void Add(Book b)
        {
            books.Add(b);
        }

        public void Remove(Book b)
        {
            books.Remove(b);
        }
        public void Delete(Book b)
        {
            books.Remove(b); 
        }

        public Book search(in string author)
        {
            Book found = null ;
            foreach(Book b in books)
            {
                if (b.Author == author)
                {
                    found = b;
                    break;
                }
            }
            return found;
        }
    }
}
