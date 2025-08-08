namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //anonymous types:
            //https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
            List<Product> products = new List<Product>
             {
                new Product{Name = "Chocolate", Quantity = 50, Price = 10},
                new Product{Name = "Fizzer", Quantity = 10, Price = 8},
                new Product{Name = "Coke", Quantity = 20, Price = 12},
                new Product{Name = "Lays", Quantity = 3, Price = 15}
            };

            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.WriteLine("Here are the products in the inventory:");

            Console.WriteLine("Product\t\tPrice");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}\t\t{product.Price:C}");
            }

            Console.WriteLine("\nPlease note that the stock is limited");
            int lowStockCount = products.LowInStock();
            Console.WriteLine("The amount of products that are low in stock: " + lowStockCount);
    }
    }
}
