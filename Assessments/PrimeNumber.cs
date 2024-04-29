//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class PrimeNumber
//    {
//        static void Main(string[] args)
//        {
//            int number = 29; 
//            if (IsPrime(number))
//            {
//                Console.WriteLine(number + " is a prime number.");
//            }
//            else
//            {
//                Console.WriteLine(number + " is not a prime number.");
//            }
//        }

//        static bool IsPrime(int n)
//        {
//            if (n <= 1)
//                return false;

//            for (int i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                    return false;
//            }

//            return true;
//        }
//    }
//}

