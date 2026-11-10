using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TongBP(double n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return Math.Pow(n, 2) + TongBP(n - 1);
                }
            }

            Console.Write("Hãy nhập số n: ");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Tổng là: " + TongBP(i));
        }
    }
}
