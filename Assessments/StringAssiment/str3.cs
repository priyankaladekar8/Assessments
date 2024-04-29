using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public class str3
    {
        static void Main()
        {
            string str = "Hello, world!";
            char target = 'o';
            int count = 0;
            foreach (char c in str)
            {
                if (c == target)
                {
                    count++;
                }
            }
            Console.WriteLine($"The character '{target}' occurs {count} times in the string.");
        }
    }
}

