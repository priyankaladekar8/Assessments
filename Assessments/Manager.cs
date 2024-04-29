//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Contracts;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//     public class Manager : Employee
//    {
//        //base keyword will call the base class constructor
//        private double food;

//        public Manager() : base()
//        {
//        }
//        public Manager(int id, String name, double b, double h, double p, double food) 
//            :base(id, name, b, h, p)
//        {
//            this.food = food;

//        }
//        //Calculate salary for Manager
//        public override void CalculateSalary()
//        {
//            gross = (bs + hra + food) - pf;
//        }
//        public override string Display()
//        {
//            return $"Manager salary empid={empid}, empname={empname},gross={gross}";
//        }
//    }



//}

