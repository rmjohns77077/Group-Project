using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{

    public class Product
    {
        public List<Consumable> Consumables { get; set; } = new List<Consumable>();


        public Product()
        {
            Consumables.Add(new Consumable("Water", "ice cold", 0.00, ProductType.Drink));
            Consumables.Add(new Consumable("Small coffee", "regular small coffee", 1.00, ProductType.Drink));
            Consumables.Add(new Consumable("Medium coffee", "regular medium coffee", 2.00, ProductType.Drink));
            Consumables.Add(new Consumable("Large coffee", "regular large coffee", 3.00, ProductType.Drink));
            Consumables.Add(new Consumable("Awesome Cup", "everything in this is awesome", 36.00, ProductType.Drink));
            Consumables.Add(new Consumable("Small latte", "premium small latte", 2.00, ProductType.Drink));
            Consumables.Add(new Consumable("Medium latte", "premium medium latte", 3.00, ProductType.Drink));
            Consumables.Add(new Consumable("Large latte", "premium large latte", 4.00, ProductType.Drink));
            Consumables.Add(new Consumable("Croissant", "buttery flakey and sweet", 1.00, ProductType.Food));
            Consumables.Add(new Consumable("Hot Chocolate", "chocolate that is hot", 2.00, ProductType.Drink));
            Consumables.Add(new Consumable("Espresso", "no depresso here!", 5.00, ProductType.Drink));
            Consumables.Add(new Consumable("Chocolate Chip Cookie", "classic", 1.00, ProductType.Food));
        }

        public void PrintProducts()
        {
            for (int i = 0; i < Consumables.Count; i++)
            {
                Consumable p = Consumables[i];
                Console.WriteLine($"Index: {i}, {p.Name}");
            }
        }

        public double TotalFinder(Consumable purchase)
        {
            Console.WriteLine($"\nWhat quantity of {purchase.Name} would you like to purchase?");
            int amount = int.Parse(Console.ReadLine());

            double subtotal = purchase.Price * amount;
            Console.WriteLine($"Your subtotal is: {subtotal}");

            double salesTax = Math.Round((subtotal * 1.06) - subtotal, 2);
            Console.WriteLine($"Your sales tax is: {salesTax}");

            double grandTotal = (purchase.Price * 1.06) * amount;
            return Math.Round(grandTotal, 2);
            
        }

        public Consumable Purchase()
        {
            Console.WriteLine("Hello and welcome to the ARA Coffee!\n");
            PrintProducts();
            Console.WriteLine("Please select the item you wish to purchase:");
            string input = Console.ReadLine();

            Console.WriteLine();

            int index = int.Parse(input);
            Consumable c = Consumables[index];
            c.PrintInfo();
            return c;
        }
    }
}
