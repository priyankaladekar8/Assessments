using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssiment
{
    public class Str4
    {
        static void Main()
        {
            string str = "    Hello, world!";
            string trimmed = str.TrimStart();
            Console.WriteLine(trimmed);
        }
    }

}
