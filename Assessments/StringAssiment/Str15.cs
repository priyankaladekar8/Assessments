using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
// 15 find duplicate words and their number of occurences in a string
namespace Assessments.StringAssiment
{
    public  class Str15
    {
        static void Main(string[] args)
        {

            string input = "hello world hello";
            var wordFrequency = input.Split(' ')
                                     .GroupBy(w => w)
                                     .ToDictionary(g => g.Key, g => g.Count());

            foreach (var kvp in wordFrequency)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"Word: {kvp.Key}, Occurrences: {kvp.Value}");
                }
            }
        }
    }
}
 