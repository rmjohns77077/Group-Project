using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    public class Helper
    {
        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public bool RunAgain()
        {
            Console.WriteLine("\nWould you like to make another purchase? Y/N");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("\nGoodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand, please input Y or N.");
                return RunAgain();
            }
        }
    }
}
