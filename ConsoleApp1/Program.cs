namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new();
            product.Title = "name";
            product.Description = "description";
            product.Price = 100;

            Console.WriteLine(product.Priceinlari());
        }
    }
}
