//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading.Tasks.Dataflow;

//namespace Assessments
//{
//    public interface ITaxable
//    {
//        double PayTax(); //public ,abstract virtual
    
//        //implicit implements of interface
//        public class Job: ITaxable { 
//        private double salary;
//        private double taxaount;

//        public   Job()
//        {
//                salary = 1000;
//        }
//            public double PayTax()
//            {
//                taxaount = salary * 0.20;
//                return taxaount;
//            }
//            public class Business : ITaxable {
//            private double salary;
//                private double taxamount;
//                public Business() {
//                    salary = 1000;
//                }
//                public double PayTax()
//                {
//                    taxamount = salary * 0.30;
//                    return taxamount;
//                }
//            }
             
//            }


//    }
//}
