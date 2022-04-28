using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    public enum ProductType
    {
        Food,
        Drink
    }

    public class Consumable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ProductType Category { get; set; }

        public Consumable(string Name, string Description, double Price, ProductType Category)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Category = Category;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Price: " + Price + " dollars.");
        }

    }
}
