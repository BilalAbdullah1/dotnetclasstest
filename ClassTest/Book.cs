using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string Title, string Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{this.Title} {this.Author} {this.Year}");
        }
    }
}
