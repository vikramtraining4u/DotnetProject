using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }


        public static int AddProduct(int productCount)
        {
            return productCount + 1;
        }
        public int RemoveProduct(int productCount)
        {
            return productCount - 1;
        }

    }
}
