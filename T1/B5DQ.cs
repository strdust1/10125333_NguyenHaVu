using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double USLmax(double n)
            {
                if (n % 2 != 0)
                {
                    return n;
                }
                else
                {
                    return USLmax( n / 2);
                }
            }

            Console.Write("Hãy nhập số n: ");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Ước số lẻ lớn nhất là: " + USLmax(i));
        }
    }
}
