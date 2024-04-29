//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;

//namespace Assessments
//{
//    internal class PellNumbercs
//    {
//        static void Main(string[] args)
//        {
//            int n = 10; 
//            Console.WriteLine("Pell Numbers:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(Pell(i) + " ");
//            }
//        }

//        static int Pell(int n)
//        {
//            if (n <= 2)
//                return n;

//            int a = 1;
//            int b = 2;
//            int c = 0;

//            for (int i = 3; i <= n; i++)
//            {
//                c = 2 * b + a;
//                a = b;
//                b = c;
//            }

//            return c;
//        }
//    }
//}
    
