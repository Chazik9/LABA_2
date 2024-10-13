using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k;
            string fStr;
            k = double.Parse(Console.ReadLine());
            Console.WriteLine(k);
            Console.WriteLine(fStr = Convert.ToString(k).TrimEnd('0'));
            Console.WriteLine(fStr);
            Console.WriteLine(fStr = fStr.TrimEnd(','));
            Console.WriteLine(fStr);

        }
    }
}
