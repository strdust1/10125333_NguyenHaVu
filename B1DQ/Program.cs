using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Tong(double n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n + Tong(n - 1);
                }
            }
            Console.WriteLine("Hãy nhập số n: ");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Tổng là: " + Tong(i));
        }
    }
}
