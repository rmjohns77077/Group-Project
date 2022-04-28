using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore
{
    class Menu
    {
        //Constructor?
        //What properties?
        //What methods?

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Menu(string Name, string Category, string Description)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
        }
    }
}
