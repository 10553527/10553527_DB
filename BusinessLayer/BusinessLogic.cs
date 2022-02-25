using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        public static void CreateBook(int ibsn, string title, string author, int year)
        {
            Book newBook = new Book(ibsn, title, author, year);
            CRUD.AddBook(newBook);
        }

        public static List<Book> GetBook(string title)
        {
            List<Book> books = new List<Book>();
            books = CRUD.GetBook(title);           
            return books;          
        }

        public static void DeleteBook(string title)
        {
            CRUD.DeleteBook(title);
        }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books = CRUD.GetBooks();
            return books;
        }

        public static void EditValue(string columnName, int ibsn, string title, string author, int year, string newValue)
        {
            if (columnName == "Title")
            {
                title = newValue;
            }
            else if (columnName == "Author")
            {
                author = newValue;
            }
            else if (columnName == "PublicationYear")
            {
                year = int.Parse(newValue);
            }

            CRUD.EditBook(ibsn, title, author, year);
        }
    }
}
