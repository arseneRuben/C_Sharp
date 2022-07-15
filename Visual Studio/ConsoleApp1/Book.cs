using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        private string title;
        private string author;
        private string editor;
        private DateTime edition;
        private string isbn;

        public string Author
        {
            get; set;
        }

        public Book(string isbn, string edit, DateTime editTime, string auth, string titre)
        {
            this.edition = editTime;
            this.author = auth;
            this.isbn = isbn;
            this.title = titre;
            this.editor = edit;
        }
        public void Print()
        {
          
                String result = "ISBN: " + this.isbn + "\n";
                result += !String.IsNullOrEmpty(this.editor) ? " " + this.editor : "\n";
                result += !String.IsNullOrEmpty(this.author) ? " " + this.author : "\n";
                result += !String.IsNullOrEmpty(this.title) ? " " + this.title : "\n";
                result += (this.edition!=null) ? " " + this.edition.ToString("MM/dd/yyyy") : "";
               Console.WriteLine(result);
            
        }
    }
}
