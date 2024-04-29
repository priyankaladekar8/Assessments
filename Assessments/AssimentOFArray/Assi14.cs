using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. wap to replace all negative value with its immediate left  elements square means arr[]=[12,3,-19, 29,5 -61, 44,7 -9] output array will be[12,3,9,29,5,25,44,7,49]
namespace Assessments.AssimentOFArray
{
    public  class Assi14
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            ReplaceNegativeSquareOFLeft(arr);
            Console.WriteLine("output array:");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");

            }


          }
     static void ReplaceNegativeSquareOFLeft(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0 && i > 0)
            {
                arr[i] = arr[i - 1] + arr[i - 1];

            } 
        } 
    }
}}
