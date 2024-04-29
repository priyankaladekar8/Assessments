//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Contracts;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    abstract public class Shape
//    {
//        public abstract void CalculateArea();

//        public void Dispaly()
//        {
//            //define some basic info about shape
//        }

//    }
//    public class Circle : Shape
//    {
//        private int radius;
//        private double result;
//        public Circle(int radius)
//        {
//            this.radius = radius;
//        }

//        public override void CalculateArea()
//        {
//            result = 3.14 * radius * radius;
//        }
//        public string print()
//        {
//            return $"Area of circle is{result}";
//        }


//    }
//    public class Rectangle : Shape
//    {
//        private double length;
//        private double width;
//        private double result;

//        public Rectangle(double length, double width)
//        {
//            this.length = length;
//            this.width = width;
//        }

//        public override void CalculateArea()
//        {
//            result = length * width;

//        }
//        public string print()
//        {
//            return $"Area of Rectangle is{result}";


//        }
//    }
//}