using ConsoleCoreApp.Models;
using System;

namespace ConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Simple Development Code");
            //Instance of a class
            Product product = new Product();
            int adddedProductResult=Product.AddProduct(10);
            Console.WriteLine($"Product Added Details::{adddedProductResult}");
            
            int removedproductResult =product.RemoveProduct(10);
            Console.WriteLine($"Product Removed Details::{removedproductResult}");
            
        }
    }
}
