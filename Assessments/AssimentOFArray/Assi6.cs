using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6.wap to find and count total number of duplicate elements in an array
namespace Assessments.AssimentOFArray
{
    public  class Assi6
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 6, 6, 5, 4, 3, 4, 5 };

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;

                }
                else {
                    frequency[num] = 1;

                }
            }
            int duplicatecount = 0;
            foreach (var pair in frequency)
            {
                if (pair.Value > 1)
                {
                    duplicatecount++;
                }
            }
            Console.WriteLine($"Total number of duplicate :{duplicatecount}");
            }
            

        }
    }

