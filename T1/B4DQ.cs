using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double LT(double x, double n)
            {
                if (n == 0)
                {
                    return 1;
                }
                else if (n < 0)
                {
                    return 1 / LT(x, -n);
                }
                else
                {
                    return x * LT(x, n - 1);
                }
            }

            Console.Write("Hãy nhập số nguyên x: ");
            double sn = double.Parse(Console.ReadLine());
            Console.Write("Hãy nhập lũy thừa n: ");
            double lt = double.Parse(Console.ReadLine());
            Console.WriteLine("Lũy thừa {0} số nguyên {1} là: {2}", lt, sn, LT(sn, lt));
        }
    }
}
