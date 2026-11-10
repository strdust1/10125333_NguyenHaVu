using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UCLN(double a, double b)
            {
                if (a % b == 0 )
                {
                    return b;
                }
                else
                {
                    return UCLN(b, a % b);
                }
            }

            Console.Write("Hãy nhập số a: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Hãy nhập số b: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ước chung lớn nhất là: " + UCLN(m, n));
        }
    }
}
