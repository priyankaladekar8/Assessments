//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class FibonacciSeriesNumber
//    {
//        static void Main(string[] args)
//        {
//            int n = 10; 
//            Console.WriteLine("Fibonacci Series:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(Fibonacci(i) + " ");
//            }
//        }

//        static int Fibonacci(int n)
//        {
//            if (n <= 1)
//                return n;

//            int a = 0;
//            int b = 1;
//            int c = 0;

//            for (int i = 2; i <= n; i++)
//            {
//                c = a + b;
//                a = b;
//                b = c;
//            }

//            return c;
//        }
//    }
//}

