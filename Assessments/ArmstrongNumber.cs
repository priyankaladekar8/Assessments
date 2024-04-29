//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class ArmstrongNumber
//    {
//        static void Main(string[] args)
//        {
//            int num;
//            int rem;
//            int sum = 0;
//            int temp;


//            Console.WriteLine("Enter a number");
//            num = Convert.ToInt32(Console.ReadLine());

//            temp = num;

//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine(" armstrong number");
//            }

//            else
//            {
//                Console.WriteLine("not armstrong number");
//            }

//        }

//    }
//}
    

