using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//extension methods
namespace prjInventoryManagement
{
    //Created the extention method to calculate the total value of products
    public static class ExtentionMethod
    {
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        // Calculates total value of all products (Price * Quantity)
        public static decimal TotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Price * p.Quantity);
        }

        // Counts how many products are low in stock (Quantity < 5)
        public static int LowInStock(this List<Product> products)
        {
            return products.Count(p => p.Quantity < 5);
        }
    }
}
