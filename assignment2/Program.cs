using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;


namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program reservationProgram = new Program();
            reservationProgram.Start();
        }

        void Start()
        {
            CustomerDao customerDao = new CustomerDao();
            List<Customer> customers = customerDao.GetAll();

            BookDao bookDao = new BookDao();
            List<Book> books = bookDao.GetAll();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            Console.Write("\nEnter customer id: ");
            int id;

            if (Int32.TryParse(Console.ReadLine(), out id))
            {
                Customer c = customerDao.GetById(id);
                if (c == null)
                {
                    Console.WriteLine($"No customer with id {id}");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("invalid id");
            }

            Console.WriteLine();

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.Write("\nEnter book id: ");

            if (Int32.TryParse(Console.ReadLine(), out id))
            {
                Book b = bookDao.GetById(id);
                if (b == null)
                {
                    Console.WriteLine($"No book with id {id}");
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("invalid id");
            }

            Console.ReadKey();
        }


    }
}