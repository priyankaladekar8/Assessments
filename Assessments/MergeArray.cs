//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////write a code to merge two array from third array 


//namespace Assessments
//{
//    public class MergeArray
//    {
//        static void Main(String[] args)
//        {
//            int[] array3 = { 1, 2, 3, 4, 5, 6, };
//            int[] array1 = new int[array3.Length / 2];
//            int[] array2 = new int[array3.Length / 2];


//            for (int i = 0; i < array3.Length; i++)
//            {
//                if (i < array3.Length / 2)
//                {
//                    array1[i] = array3[i];
//                }
//                else {
//                    array2[i - array3.Length / 2] = array3[i];
//                }

//            }
//            Console.WriteLine("first array:");
//            foreach (var num in array1)
//            {
//                Console.WriteLine(num + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Secons array");
//            foreach (var num in array2)
//            {
//                Console.WriteLine(num + " ");
//            }
//            Console.WriteLine();


//        }
//    }
//}
