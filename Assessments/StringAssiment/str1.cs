using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// wap to split string into 2 tokens where strig is "HELLO$WORLD"

namespace Assessments.StringAssiment
{
    public  class str1
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            string[] tokens = str.Split('$');
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
        }


    }
}

