using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class LibraryManagment
    {
        private static List<Book> books = new List<Book>();

        public static void Run()
        {
            while (true)
            {
                OfferingChoice();
            }
        }

        private static void OfferingChoice()
        {
            
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List all Books");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            int choice = Convert.ToInt32(Console.ReadLine()); 

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    ListAllBooks();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public static void AddBook()
        {
            Console.WriteLine("Enter Book Details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();

            Console.Write("Author Biography: ");
            string authorBio = Console.ReadLine();

            Category.ListPredefinedCategories();
            Console.Write("Category Name: ");
            string categoryName = Console.ReadLine();

            Category selectedCategory = Category.GetCategoryByName(categoryName);
            if (selectedCategory == null)
            {
                Console.WriteLine("Invalid category.");
                return;
            }

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Author author = new Author(authorName, authorBio);
            //Category category = new Category(categoryName, categoryDesc);
            Book book = new Book(title, author, selectedCategory, year, price);

            books.Add(book);
            Console.WriteLine("Book added succesfully.");
        }

        public static void RemoveBook()
        {
            Console.Write("Enter the title of the book to remove: ");
            string title = Console.ReadLine();
            Book bookToRemove = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully!");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public static void ListAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("List of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}, Category: {book.Category.CategoryName}, Year: {book.Year}, Price: {book.Price}");
                }
            }
        }
    }


}
