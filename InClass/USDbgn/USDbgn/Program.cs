using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDbgn
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = double.Parse(Console.ReadLine());
            var usd = bgn* 1.79549;
            var result = Math.Round(usd, 2);

            Console.WriteLine(result + " BGN");
        }
    }
}
