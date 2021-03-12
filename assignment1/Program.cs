using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace assignment1
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
            Customer c1 = new Customer(0, "Lionel", "Messi", "lionelmessi@hotmail.com");
            Customer c2 = new Customer(1, "Don", "Henley", "donhenley@gmail.com");

            Book b1 = new Book(0, "Harry Potter and the Prisoner of Azkaban", "J.K. Rowling");
            Book b2 = new Book(1, "The Da Vince Code", "Dan Brown");

            Reservation r1 = new Reservation(0, c1, b2);
            Reservation r2 = new Reservation(1, c2, b2);

            Console.WriteLine("testing customers");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("\ntesting books");
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            Console.WriteLine("\ntesting reservations");
            Console.WriteLine(r1);
            Console.WriteLine(r2);

            Console.ReadKey();
        }
    }
}