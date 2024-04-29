using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// wap to search for a given no in an array and accordingly print the index if exist
namespace Assessments.AssimentOFArray

{
    public class Assi1
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 5, 6, 7, 8 };
            int t = 6;
            int index = -1;

            for (int i = 0; i < number.Length; i++) 
            {
                if (number[i] == t)
                {
                    index = i;
                    break;
                }
            }


            if (index != -1)
            {
                Console.WriteLine($"The number {t} is fount at index {index}");

            }
            else
            {
                Console.WriteLine($"the number {t} is not found in the array");
            }
        }
    }
}

