using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to put even and odd elements of array in two separate arrays.

namespace Assessments.AssimentOFArray
{
    
    public  class Assi4
    {

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] even = new int[array.Length];
            int evencount = 0;

            int[] odd = new int[array.Length];
            int oddcount = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    even[evencount++] = num;

                }
                else
                {
                    odd[oddcount++] = num;

                }

            }
            Array.Resize(ref even, evencount);
            Array.Resize(ref odd, oddcount);

            Console.WriteLine("even elements: ");

            foreach (int num in even)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("odd elements: ");

            foreach (int num in odd)
            {
                Console.WriteLine(num);

            }
        }


    }
}
