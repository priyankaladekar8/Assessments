using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 12 find highest frequency charector in a string
namespace Assessments.StringAssiment
{
    public class str12
    {
        static void Main(string[] args)
        {
            string str = "leaning dotnet";
            var fre = str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            char highest=fre.OrderByDescending(kv=>kv.Value).First().Key;

            Console.WriteLine($"highest fquency chracter:{highest}");
                }
    }
}
