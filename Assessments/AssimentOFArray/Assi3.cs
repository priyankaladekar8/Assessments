using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.AssimentOFArray
{

    //3 wap to print all negative elements in an array and also count total number of negative elements in an array
    public class Assi3
    {

        static void Main(String[] args)
        {
            int[] array = { 1, -2, 3, -4, 5, -6, 7, 8, -9, };
            int count = 0;

            Console.WriteLine("negative elements in the array:");

            foreach (int num in array)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                    count++;
                }
                
                }
            Console.WriteLine($"total negative numbers  {count}");
            }
        }
    }

