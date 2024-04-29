using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// wap to sort array elemennts in asending order
namespace Assessments.AssimentOFArray
{
    public class Assi11
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 7, 1, 3 };

            SortArray(arr);
            Console.WriteLine("sorted array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void SortArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
