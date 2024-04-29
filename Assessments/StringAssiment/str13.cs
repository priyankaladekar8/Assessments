using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// write a code find total number of alphabets digits or special charector in a string
namespace Assessments.StringAssiment
{
    public class str13
    {
        static void Main(string[] args)
        {
            string str = "PRIyanka1#2$6";
            int alpha = str.Count(char.IsLetter);
            int digit = str.Count(char.IsDigit);
            int spchar = str.Length - alpha - digit;

            Console.WriteLine("Alphabets are: {alpha }, Digita:{digit}, special charecters:{spchar}");
        }

    }
}
