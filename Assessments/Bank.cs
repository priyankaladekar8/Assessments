//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
    
    
//        public delegate void MyBankDelete();
//        public class Bank
//        {
//            //             delete        event name
//            public event MyBankDelete LowBalance;
//            private double balance;
//            public Bank()
//            {
//                balance = 5000;
//            }
//            public void Withdraw(double amount)
//            {
//                if (amount > balance)
//                {
//                    LowBalance(); // call or raise an event
//                }
//                else
//                {
//                    balance -= amount;
//                }
//            }

//            public override string ToString()
//            {
//                return $" Your balance is {balance}";
//            }
//        }


//        public class MyMessage
//        {
//            public void BalanceMsg()
//            {
//                Console.WriteLine("You have low balance");
//            }
//        }
//    }


