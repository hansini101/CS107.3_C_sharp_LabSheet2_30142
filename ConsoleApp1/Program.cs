using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Ball", 500.00);

            ProductDetails(product1);
            Console.ReadLine();
        }
        static void ProductDetails(Product product)
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Product Details:{product.ProductName}");
            Console.WriteLine($"Price:${product.Price}");
        }
    }
}
