using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2 write two methods that return the average of an array with following headers
//i  public static int average(int [] array)
//ii public static double average(double[] array)
// iii write main and invoke the 2 method

namespace Assessments.AssimentOFArray
{
    public class Assi2
    {

        public static int Average(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;     //return 0 if array is empty
            }
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;

        }
        public static double Average(double[] array)
        {
            if (array.Length == 0)

            {
                return 0.0;
            }
            double sum = 0.0;
            foreach (double num in array)
            {
                sum = sum + num;
            }
            return sum / array.Length;
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 1.4, 1.5, 1.7, 1.6, 4.5 };

            Console.WriteLine("Average of int array: " + Average(intArray));
            Console.WriteLine("Average of double array:  " + Average(doubleArray));

        }
    }
}
