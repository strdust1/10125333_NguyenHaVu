using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Can(int a, int n)
            {
                if (a == n)
                {
                    return Math.Sqrt(n);
                }
                else
                {
                    return Math.Sqrt(a + Can(a + 1, n));
                }
            }

            Console.Write("Hãy nhập số n: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua: " + Can(1, x));
        }
    }
}
