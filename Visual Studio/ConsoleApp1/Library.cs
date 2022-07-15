using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
       
        
        public String Name
        {
            get; set;
        }

        public Library(List<Book> l)
        {
            this.Books = l;
        }

        public List<Book> Books
        {
            get; set;
        }
        public Library(List<Book> l, string name)
        {
            this.Books = l;
            this.Name = name;
        }

        public void Add(Book b)
        {
            Books.Add(b);
        }

        public void Remove(Book b)
        {
            Books.Remove(b);
        }
      

        public Book search(in string author)
        {
            Book found = null ;
            foreach(Book b in Books)
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
