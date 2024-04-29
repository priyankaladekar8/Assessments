//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{
//    public class Shopping
//    {
//        public int id { get; set; }
//        public string name { get; set; }
//        public double price { get; set; }
//        public int quantity { get; set; }


//        public Shopping(int id, string name, double price, int quantity)
//        {
//            this.id = id;
//            this.name = name;
//            this.price = price;
//            this.quantity = quantity;

//        }
//        public double CalculateTotalBill()
//        {
//            if (quantity > 0)
//            {
//                return price + quantity;
//            }
//            else
//            {
//                Console.WriteLine($"Error quantity for product {name} should be greate than 0");
//                return -1;
//            }
//        }
//        public void DisplayShoppingDetails()
//        {
//            Console.WriteLine($"Product Id:{id}");
//            Console.WriteLine($"product Name:{name}");
//            Console.WriteLine($"price: {price}");
//            Console.WriteLine($"Quantity: {quantity}");

//            double totalBill = CalculateTotalBill();

//            if (totalBill >= 0)
//            {
//                Console.WriteLine($"total bill:{totalBill}");
//            }
//        }
//    }
//}