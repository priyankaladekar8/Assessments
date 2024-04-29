using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public class Str5
    
    {
        static void Main()
        {
            string str = "Hello, world! This is a test string.";
            int wordCount = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Total number of words: {wordCount}");
        }
    }
}

