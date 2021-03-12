using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public String Author { get; set; }
        public int Id { get; set; }
        public String Title { get; set; }

        public Book(int id, string title, string author)
        {
            Author = author;
            Id = id;
            Title = title;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
    }
}