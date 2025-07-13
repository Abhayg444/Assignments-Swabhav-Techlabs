using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_App
{
    internal class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public readonly double DiscountPercentage = 20;

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public decimal GetDiscountedPrice()
        {
            return Price - (Price * (decimal)(DiscountPercentage / 100));
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"\nProduct ID: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Original Price: {Price} Rs");
            Console.WriteLine($"Discounted Price: {GetDiscountedPrice()} Rs\n");
        }
    }
}
