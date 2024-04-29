using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public class str8
    {
        static void Main()
        {
            string str = "Hello, world!";
            int vowelCount = 0;
            int consonantCount = 0;
            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine($"Total number of vowels: {vowelCount}");
            Console.WriteLine($"Total number of consonants: {consonantCount}");
        }

    }
}
