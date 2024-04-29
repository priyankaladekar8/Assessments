using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.AssimentOFArray
{
    public class Assi10
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 5, 6, 7, 8, 9, 10, };

            HashSet<int> merge = new HashSet<int>();

            foreach (int num in arr1)
            {
                merge.Add(num);
              }
            foreach (int num in arr2)
            {
                merge.Add(num);
            }
            int[] result=new int[merge.Count];

            merge.CopyTo(result);

            Console.WriteLine("merged array without duplicate elements: ");

            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}
