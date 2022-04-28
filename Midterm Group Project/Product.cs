using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    public class Product
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string Name, string Description, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        
            Products.Add(new Product("Water", "ice cold", 0.00));
            Products.Add(new Product("Small coffee", "regular small coffee", 1.00));
            Products.Add(new Product("Medium coffee", "regular medium coffee", 2.00));
            Products.Add(new Product("Large coffee", "regular large coffee", 3.00));
            Products.Add(new Product("Awesome Cup", "everything in this is awesome", 36.00));
            Products.Add(new Product("Small latte", "premium small latte", 2.00));
            Products.Add(new Product("Medium latte", "premium medium latte", 3.00));
            Products.Add(new Product("Large latte", "premium large latte", 4.00));
            Products.Add(new Product("Croissant", "buttery flakey and sweet", 1.00));
            Products.Add(new Product("Hot Chocolate", "chocolate that is hot", 2.00));
            Products.Add(new Product("Espresso", "no depresso here!", 5.00));
            Products.Add(new Product("Chocolate Chip Cookie", "classic", 1.00));
        }
        public void PrintProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];
                Console.WriteLine($"Index: {i}, {p.Name}");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Description: "+Description);
            Console.WriteLine("Price: "+Price+" dollars.");
        }
    }
}
