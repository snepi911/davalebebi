namespace Class_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> menu = new List<Product>{
            new Product(1, "Spicy Peanut Noodles", 12.50m, true, "noodles.jpg", true, 4, "Asian"),
            new Product(2, "Margherita Pizza", 9.99m, false, "pizza.jpg", true, 0, "Italian"),
            new Product(3, "Grilled Chicken Burger", 14.00m, false, "burger.jpg", false, 1, "Fast Food")
        };

            Console.WriteLine("--- Full Menu ---");
            foreach (var product in menu)
            {
                product.DisplayInfo();
            }

            
            Console.WriteLine();
            menu[0].ApplyDiscount(10);

            
            Console.WriteLine($"\nIs '{menu[1].Name}' safe for nut allergies? {menu[1].IsNutFree()}");
        }
    }
}
