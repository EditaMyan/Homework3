using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Book(string title, Author author, Category category, int year, decimal price)
        {
            Title = title;
            Author = author;
            Category = category;
            Year = year;
            Price = price;
        }
    }
}
