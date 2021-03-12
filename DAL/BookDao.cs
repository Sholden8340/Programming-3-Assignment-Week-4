using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class BookDao
    {
        private SqlConnection dbConnection;

        public BookDao()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book b = ReadBook(reader);
                books.Add(b);
            }

            dbConnection.Close();
            return books;
        }

        public Book GetById(int id)
        {
            dbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Books WHERE Id = {id}", dbConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Book book = null;

            while (reader.Read())
            {
                book = ReadBook(reader);
            }

            dbConnection.Close();
            return book;
        }

        private Book ReadBook(SqlDataReader reader)
        {
            return new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
        }
    }
}