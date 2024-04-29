using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  // write a code to reverse order of words in a given string

namespace Assessments.StringAssiment
{
    public  class str11
    {
        static void Main(string[] args)
        {
            string st = "learn dotnet";

            string[] s = st.Split(" ");
            Array.Reverse(s);

            string reversed = string.Join(" ", s);
            Console.WriteLine(reversed);

        }
    }
}
