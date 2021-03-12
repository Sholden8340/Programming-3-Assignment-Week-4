using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class CustomerDao
    {

        private SqlConnection dbConnection;

        public CustomerDao()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Customer> GetAll()
        {
            dbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Customers", dbConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer c = ReadCustomer(reader);
                customers.Add(c);
            }
            dbConnection.Close();
            return customers;
        }

        public Customer GetById(int id)
        {
            dbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Customers WHERE Id = {id}", dbConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Customer customer = null;

            while (reader.Read())
            {
                customer = ReadCustomer(reader);
            }

            dbConnection.Close();
            return customer;
        }

        private Customer ReadCustomer(SqlDataReader reader)
        {
            return new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
        }
    }
}
