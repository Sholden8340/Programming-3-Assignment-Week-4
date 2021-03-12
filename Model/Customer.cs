using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Id { get; set; }
        public string LastName { get; set; }

        public Customer(int id, string firstName,  string lastName, string emailAddress)
        {
            EmailAddress = emailAddress;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FullName} ({EmailAddress})";
        }
    }
}