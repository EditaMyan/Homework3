using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public sealed class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        private static List<Category> predefinedCategories = new List<Category>()
        {
        new Category("Fiction", "Books that describe imaginary events or people."),
        new Category("Non-Fiction", "Books that are based on facts and real events."),
        new Category("Science Fiction", "Books that feature futuristic science and technology."),
        new Category("Mystery", "Books that involve solving a crime or puzzle."),
        new Category("Romance", "Books that focus on romantic love stories."),
        new Category("Fantasy", "Books that contain magic, mythical creatures, or supernatural elements.")
        };

        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }

        public static void ListPredefinedCategories()
        {
            Console.WriteLine("Predefined Categories:");
            foreach (var category in predefinedCategories)
            {
                Console.WriteLine($"{category.CategoryName}: {category.Description}");
            }
        }

        public static Category GetCategoryByName(string categoryName)
        {
            return predefinedCategories.Find(c => c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
