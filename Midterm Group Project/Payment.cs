using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    public class Payment
    {
        public Payment()
        {
        }
        public void PayUs(string input, double total)
        {
            bool paid = false;
            if (input.ToLower().Trim().Contains("cash"))
            {
                do
                {
                    Console.WriteLine($"\nYour total is ${total}");
                    Console.WriteLine("Please enter your payment:");
                    double tender;
                    double.TryParse(Console.ReadLine(), out tender);
                    double due = (total) - tender;
                    if (due == 0)
                    {
                        Console.WriteLine("Thanks, you're all set!");
                        paid = true;
                        break;
                    }
                    else if (due < 0)
                    {
                        double change = tender - total;
                        Console.WriteLine($"Here's ${Math.Round(change, 2)} back...");
                        Console.WriteLine("Thanks, you're all set!");
                        paid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that, please try again.");
                        paid = false;
                        continue;
                    }
                }
                while (paid == false);
            }
            else if (input.ToLower().Trim().Contains("credit"))
            {
                do
                {
                    Console.WriteLine("\nPlease enter your card number:");
                    string card = Console.ReadLine();
                    if (card.Length == 16)
                    {
                        Console.WriteLine("Please enter the CVV:");
                        string cvv = Console.ReadLine();
                        if (cvv.Length == 3 || cvv.Length == 4)
                        {
                            Console.WriteLine("Please enter the expiration date: MM/DD/YYYY");
                            string expdate = Console.ReadLine();
                            if (expdate.Length == 8)
                            {
                                Console.WriteLine("Card accepted. Thanks, you're all set.");
                                paid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid expiration date.");
                                paid = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid CVV.");
                            paid = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid card number.");
                        paid= false;
                    }
                }
                while (paid == false);
            }
            else if (input.ToLower().Trim().Contains("check"))
            {
                do
                {
                    Console.WriteLine("\nPlease enter your check number:");
                    string check = Console.ReadLine();
                    if (check.Length == 4)
                    {
                        Console.WriteLine("What amount would you like to pay?");
                        double tender = double.Parse(Console.ReadLine());
                        double change = tender - total;
                        Console.WriteLine($"Here's ${Math.Round(change, 2)} back...");
                        Console.WriteLine("Thanks, you're all set!");
                        paid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid check number.");
                        paid = false;
                    }
                }
                while (paid == false);
            }
            else
            {
                Console.WriteLine("That payment type was not accepted, please try again.");
            }        
                 
        }
    }
}
