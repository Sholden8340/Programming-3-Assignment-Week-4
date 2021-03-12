using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDateTime { get; set; }

        public Book Book { get; set; }
        public Customer Customer { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            this.Id = id;
            this.Customer = customer;
            this.Book = book;
        }

        public override string ToString()
        {
            return $"{Customer.ToString()} -> {Book.ToString()}";
        }
    }
}