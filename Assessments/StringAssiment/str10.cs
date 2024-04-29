using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public  class str10
    {
        static void Main()
        {
            string str = "Hello, world!";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine($"Reverse of the string: {reversedString}");
        }
    }
}

