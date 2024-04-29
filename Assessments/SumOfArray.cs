//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    public  class SumOfArray
//    {
//        static void Main(string[] args)
//        {
//            int[,] array1 = new int[3, 3];
//            int[,] array2 = new int[3, 3];
//            int[,] add = new int[3, 3];

//            Console.WriteLine("Enter first array");
//            for (int i = 0; i < array1.GetLength(0); i++)
//            {
//                for (int j = 0; j < array1.GetLength(1); j++)
//                {
//                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
//                } 
//            }
//            Console.WriteLine("enter second array");
//            for (int i = 0; i < array2.GetLength(0); i++)
//            {
//                for (int j = 0; j < array2.GetLength(0); j++)
//                {
//                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

//                }
//            }
//            Console.WriteLine("Addition of 3*3 matrix is");
//            for (int i = 0; i < add.GetLength(0); i++)
//            {
//                for (int j = 0; j < array1.GetLength(1); j++)
//                {
//                    add[i, j] = array1[i, j] + array2[i, j];
//                    Console.WriteLine(add[i, j] + " ");
//                }
//            }
                        
                        
//                        }
//       }
//}
