using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLH_I_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'a' oldal hossza: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("'b' oldal hossza: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Terület: {2*(a+b)}, Kerület: {a*b}");
            Console.WriteLine("almafa");

        }
    }
}
