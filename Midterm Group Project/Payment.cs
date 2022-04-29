using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    public enum PaymentType
    {
        Cash,
        Check,
        Credit
    }
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
                    Console.WriteLine($"Your total is {total}");
                    Console.WriteLine("Please enter your payment:");

                    double tender = double.Parse(Console.ReadLine());

                    //can validate for acceptable parse here 

                    double due = (total) - tender;
                    
                    if (due == 0)
                    {
                        Console.WriteLine("Thanks, you're all set!");
                        break;
                    }
                    else if (due < 0)
                    {
                        double change = tender - total;
                        Console.WriteLine($"Here's {Math.Round(change, 2)} back...");
                        Console.WriteLine("Thanks, you're all set!");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that, please try again.");
                        continue;
                        
                    }

                }
                while (paid = false); 
            }
          
            /*
            else if (input.Contains("credit"))
            {

            }
            else if (input.Contains("check"))
            {

            }
            else
            {
                Console.WriteLine("That payment type was not accepted, please try again.");
            }
            */

        }


    }
}
