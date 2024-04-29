using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//wap to print all unique elements

namespace Assessments.AssimentOFArray
{
    public class Assi7
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 9, 3, 4, 5 };


            HashSet <int> unique = new HashSet<int>();

            foreach (int num in array)
            {
                if (unique.Contains(num))
                {
                    unique.Add(num);
                } 
            }
            Console.WriteLine("unique elements in array: ");
            foreach (int e in unique)
            {
                Console.WriteLine(e);

            }

        }
    }
}
