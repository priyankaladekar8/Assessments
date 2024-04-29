using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//check valid mobile number
namespace Assessments.StringAssiment
{
    public class Str14
    {
        static void Main(string[] args)
        {
            string phno = "8467588998";
            string spchar = "@^|d{3}-{4}$";
            bool isValid = Regex.IsMatch(phno, spchar);
            Console.WriteLine($"is valid number:{isValid}");
        }
    }
}
