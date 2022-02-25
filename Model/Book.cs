using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public int IBSN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
      
        public Book()
        { }

        public Book(int ibsn, string title, string author, int pubYear)
        {
            IBSN = ibsn;
            Title = title;
            Author = author;
            PublicationYear = pubYear;
        }
    }
}
