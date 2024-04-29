//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    public class Employee :IComparable<Employee>
//    {
//        private int id;
//        private string name;
//        private double salary;

//        public Employee(int id, string name, double salary)
//        {
//            this.id = id;
//            this.name = name;
//            this.salary = salary;
//        }

//        public int CompareTo(Employee? other)
//        {
//            if (this.salary > other.salary)
//            {
//                return 1;

//            }
//            else if (this.salary < other.salary)
//            {
//                return -1;

//            }
//            else if (this.salary < other.salary)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;

//            }
//        }
//        public override string ToString()
//        {
//            return $"name={name},salary={salary}";
            
//        }
//    }
//    public class Department: IEnumerable
//    {
//        private Employee[] Employee;
//        public Department();
//    }
    
//}
