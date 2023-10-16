using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Two_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 87, b = 45;
            a= a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Before swapping a=87 and b=45");
            Console.WriteLine($"After swapping a={a} and b={b}" );
            Console.WriteLine("*********************************");

            int x = -13, y = 2, Z;
            Z = x;
            x = y;
            y = Z;
            Console.WriteLine("Before swapping x=-13 and y=2 ");
            Console.WriteLine($"After swapping x={x} and y={y} ");
            Console.ReadLine();

        }
    }
}
