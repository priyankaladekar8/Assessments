using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    internal class Str7
    {
        static void Main()
        {
            string str = "Hello, World!";
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (char.IsLower(c))
                {
                    result[i] = char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    result[i] = char.ToLower(c);
                }
                else
                {
                    result[i] = c; // If not a letter, keep it unchanged
                }
            }
            string toggledString = new string(result);
            Console.WriteLine(toggledString);
        }
    }
}

