using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.SirSessionCodes
{
    delegate void MyDelegate(string message);
    public  class DelegateAndEvents
    {
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);

        }
        static void main(string[] args)
        {

            MyDelegate d = new MyDelegate(PrintMessage);
            d("priyanka");
            d += new MyDelegate(PrintMessage);
            d("hello world");
        }
    }
}
