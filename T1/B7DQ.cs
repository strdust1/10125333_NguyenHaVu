using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7DQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sochuso(int a)
            {
                if (a == 0)
                {
                    return 0;
                }
                else
                {
                    return Sochuso (a / 10) + 1;
                }
            }

            Console.Write("Hãy nhập số a: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Số các chữ số của a là: " + Sochuso(m));
        }
    }
}
