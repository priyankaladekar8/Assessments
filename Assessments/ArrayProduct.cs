using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class Product1
    
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }

        public Product1(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }       
}

