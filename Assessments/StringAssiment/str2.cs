using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public class str2
    {
        public void Main(string[] args)
        {
            string str = "Hello, world!";
            char target = 'o';
            int index = str.IndexOf(target);
            if (index != -1)
            {
                Console.WriteLine($"The first occurrence of '{target}' is at index {index}");
            }
            else
            {
                Console.WriteLine($"'{target}' not found in the string.");
            }
        }
    }
}
  
