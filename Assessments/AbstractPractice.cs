//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    public abstract class AbstractPractice
//    {
//        protected int n1;


//        public AbstractPractice(int n1)
//        {
//            this.n1 = n1;
//        }
//        public abstract int PerformOperation(int n2);
        
//    }

//    public interface Iinterfacepractice
//    {
//        int n2 { get; set; }
//        int PerformOperation();
//    }

//    public class ChildClass : AbstractPractice, Iinterfacepractice
//    {
//        public int n2 { set; get; }

//        public ChildClass(int n1, int n2) : base(n1)
//        {
//            this.n2 = n2;
//        }

//        public override int PerformOperation(int n2)
//        {
//            return this.n1 + n2;
//        }

//        public int PerformOperation()
//        {
//            return this.n1 + this.n2;
//        }
//    }
//}
