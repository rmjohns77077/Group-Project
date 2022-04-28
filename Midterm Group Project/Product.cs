using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Water,
//CoffeeSmall,
//CoffeeMedium,
//CoffeeLarge,
//AwesomeCup,
//LatteSmall,
//LatteMedium,
//LatteLarge,
//Croissant,
//HotChocolate,
//Espresso,
//ChocolateChipCookie
namespace CoffeeStore
{
    //Enum?
    class Product
    {
        //Constructor?
        //What properties?
        //What methods?

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string Name, string Description, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Description: "+Description);
            Console.WriteLine("Price: "+Price);
        }
    }
}
