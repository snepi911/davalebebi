using System;
using System.Collections.Generic;
using System.Text;

namespace Class_hw
{
    internal class Product
    {
        public Product(int id, string name, decimal price, bool nuts, string image, bool vegetarian, int spiciness, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Nuts = nuts;
            Image = image;
            Vegetarian = vegetarian;
            Spiciness = spiciness;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Nuts { get; set; }
        public string Image { get; set; }
        public bool Vegetarian { get; set; }
        public int Spiciness { get; set; }
        public string Category { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"[{Id}] {Name} - ${Price:F2} ({Category})");
            Console.WriteLine($"Vegetarian: {(Vegetarian ? "Yes" : "No")} | Nuts: {(Nuts ? "Contains Nuts" : "Nut-Free")} | Spiciness: {Spiciness}/5");
            Console.WriteLine($"Image URL: {Image}");
            Console.WriteLine(new string('-', 40));
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (percentage > 0 && percentage <= 100)
            {
                Price -= Price * (percentage / 100m);
                Console.WriteLine($"Discount applied! New price for {Name}: ${Price:F2}");
            }
            else
            {
                Console.WriteLine("Invalid discount percentage.");
            }
        }

        public bool IsNutFree()
        {
            return !Nuts;
        }

    }
}
