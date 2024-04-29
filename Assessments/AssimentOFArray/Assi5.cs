using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//wap to find the maximum and minimum value in an array

namespace Assessments.AssimentOFArray
{
    public class Assi5
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, 6, 7, 8, 9, 1, 3, 2 };

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];

                }


            }
            Console.WriteLine("Minimum value in the array: " + min);
            Console.WriteLine("maximum value in the array: " + max);
        }

    }
}
