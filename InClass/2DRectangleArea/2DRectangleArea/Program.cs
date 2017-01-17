using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = x2 - x1;
            var b = y2 - y1;

            if(a<0)
            {
                a = -a;
            }

            if (b < 0)
            {
                b = -b;
            }

            var area = a * b;
            var perimeter = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            
        }
    }
}
