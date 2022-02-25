using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using Model;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace DataAccess
{
    public class CRUD
    {
        // IDbConnection Approach from Tim Corey, YouTube (2017)
        // Transactions with Dapper from dapper-tutorial.net (2020)
        // Try-Catch Statements in Transactions from C# Corner (2020)

        public static void AddBook(Book b)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("DBCS")))
            {
                IDbCommand command = connection.CreateCommand();
                IDbTransaction transaction;

                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                try
                {
                    var procedure = "dbo.spInsertBook";
                    var values = new { IBSN = b.IBSN, Title = b.Title, Author = b.Author, PublicationYear = b.PublicationYear };
                    var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure, transaction: transaction);

                    transaction.Commit();
                    MessageBox.Show("Book Added!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Message: " + e.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Message: " + e2.Message);
                    }
                }
                
                connection.Close();
            }
        }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            using (IDbConnection connection = new SqlConnection(Helper.ConnValue("DBCS")))
            {
                IDbCommand command = connection.CreateCommand();
                IDbTransaction transaction;

                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = $"select * from Book";

                    IDataReader rdr = command.ExecuteReader();

                    while (rdr.Read())
                    {
                        int IBSN = int.Parse(rdr[0].ToString());
                        string Title = rdr[1].ToString();
                        string Author = rdr[2].ToString();
                        int PublicationYear = int.Parse(rdr[3].ToString());
                        Book b = new Book(IBSN, Title, Author, PublicationYear);
                        books.Add(b);
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Message: " + e.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Message: " + e2.Message);
                    }
                }

                connection.Close();
            }

            return books;
        }

        public static List<Book> GetBook(string title)
        {
            List<Book> books = new List<Book>();

            using (IDbConnection connection = new SqlConnection(Helper.ConnValue("DBCS")))
            {
                IDbCommand command = connection.CreateCommand();
                IDbTransaction transaction;

                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = $"select * from Book where Title = '{ title }'";
                    IDataReader rdr = command.ExecuteReader();

                    while (rdr.Read())
                    {
                        int IBSN = int.Parse(rdr[0].ToString());
                        string Author = rdr[2].ToString();
                        int PublicationYear = int.Parse(rdr[3].ToString());
                        Book b = new Book(IBSN, title, Author, PublicationYear);
                        books.Add(b);                        
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Message: " + e.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Message: " + e2.Message);
                    }
                }

                connection.Close();
                
            }

            return books;
        }
        
        public static void DeleteBook(string title)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnValue("DBCS")))
            {
                IDbCommand command = connection.CreateCommand();
                IDbTransaction transaction;

                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                try
                {

                    var procedure = "dbo.DeleteBook";
                    var values = new { Title = title };
                    var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure, transaction: transaction);

                    transaction.Commit();
                    MessageBox.Show("Book Deleted!");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Message: " + e.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Message: " + e2.Message);
                    }
                }

                connection.Close();
            }
        }

        public static void EditBook(int ibsn, string title, string author, int year)
        {
            Book b = new Book();

            b.IBSN = ibsn;
            b.Title = title;
            b.Author = author;
            b.PublicationYear = year;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("DBCS")))
            {
                IDbCommand command = connection.CreateCommand();
                IDbTransaction transaction;

                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    var procedure = "dbo.spUpdateBook";
                    var values = new { IBSN = b.IBSN, Title = b.Title, Author = b.Author, PublicationYear = b.PublicationYear };
                    var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure, transaction: transaction);

                    transaction.Commit();
                    MessageBox.Show("Book Updated");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Message: " + e.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Message: " + e2.Message);
                    }
                }

                connection.Close();
            }
        }

    }
}

