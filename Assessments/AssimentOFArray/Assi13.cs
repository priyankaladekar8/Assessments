using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//13 write a code to test the quality of two arrays.means arr[]=[12,22,32,42,52,62] and arr2[]=[52,22,62,12,42,22] heare both array equal
namespace Assessments.AssimentOFArray
{
    public class Assi13
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 22 };

            bool areEqual = AreArrayEqual(arr1, arr2);
            if (areEqual)
            {
                Console.WriteLine("Both array are equals ");
            }
            else {
                Console.WriteLine("Both array are not equal");

            }
        }
        static bool AreArrayEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;

            }
            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    return false;

                }
            }
            return true;
        }
    }
}
