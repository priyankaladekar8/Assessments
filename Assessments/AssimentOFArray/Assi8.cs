using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to find the second smallest elements in an array
namespace Assessments.AssimentOFArray
{
   public class Assi8
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 7, 2, 5, 6, 5, 7 };
                
                int smallest = int.MaxValue;
            int secondsmall = int.MaxValue;
            foreach (int num in array)
            {
                if (num < smallest)
                {
                    secondsmall = smallest;
                    smallest = num;

                }
                else if (num < secondsmall && num != smallest)
                {
                    secondsmall = num;
                } 
            }
            if (secondsmall == int.MaxValue)
            {
                Console.WriteLine("Ther is no second smallest element in the array:");
            }
            else
            {
                Console.WriteLine("Second smallest element in the array: " + secondsmall);

            }

        }
    }
}
