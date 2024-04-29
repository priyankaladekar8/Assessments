using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 12  wap to reverse the array itself dont print array in reverse i want curremt array reverse. means arr[]=[3,90,45,29, 37,78]
//without using temporary array
namespace Assessments.AssimentOFArray
{
    public class Assi12
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            reverseArray(arr);

            Console.WriteLine("reversed array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");

            }
        }
        static void reverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                arr[start] = arr[start] + arr[end];
                arr[end] = arr[start] - arr[end];

                start++;
                end--;


            }
        }
    }
}