using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to count frquency of each elements in array

namespace Assessments.AssimentOFArray
{
    public class Assi9
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 7, 6, 5, 4, 4, 5, 6, 3, 2 };
            Dictionary<int, int> frquency = new Dictionary<int, int>();

            foreach (int num in array)

            {
                if (frquency.ContainsKey(num))
                {
                    frquency[num]++;

                }
                else
                {
                    frquency[num] = 1;
                }
            }
            Console.WriteLine("frquency of each element in arry:");
            foreach (var pair in frquency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }


        }
    }
}

