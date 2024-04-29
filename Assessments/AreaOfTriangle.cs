//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    internal class AreaOfTriangle
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the length of the three sides of the triangle");
//            double side1 = Convert.ToDouble(Console.ReadLine());

//            double side2 = Convert.ToDouble(Console.ReadLine());

//            double side3 = Convert.ToDouble(Console.ReadLine());

//            double area = CalculateArea(side1, side2, side3);
//            Console.WriteLine("The area of the triangle is");


//        }
//        static double CalculateArea(double a, double b, double c)
//        {
//            double s = (a + b + c) / 2;
//            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
//        }
//    }
//}
