//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class PallindromNumber
//    {
//        static void Main(string[] args)
//        {
//            int number = 12321; 
//            if (IsPalindrome(number))
//            {
//                Console.WriteLine(number + " is a palindrome number.");
//            }
//            else
//            {
//                Console.WriteLine(number + " is not a palindrome number.");
//            }
//        }

//        static bool IsPalindrome(int n)
//        {
//            int originalNumber = n;
//            int reversedNumber = 0;
//            while (n > 0)
//            {
//                int digit = n % 10;
//                reversedNumber = reversedNumber * 10 + digit;
//                n /= 10;
//            }
//            return originalNumber == reversedNumber;
//        }
//    }
//}

