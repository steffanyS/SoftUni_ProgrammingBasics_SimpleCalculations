using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine();
            var currency2 = Console.ReadLine();
            double currency3 = 0;

            if(currency1=="BGN")
            {
                num = num * 1;
            }

            if (currency1 == "USD")
            {
                num = num * 1.79549;
            }

            if (currency1 == "EUR")
            {
                num = num * 1.95583;
            }

            if (currency1 == "GBP")
            {
                num = num * 2.53405;
            }

            if (currency2 == "BGN")
            {
                currency3 = 1;
            }

            if (currency2 == "USD")
            {
                currency3 = 1.79549;
            }

            if (currency2 == "EUR")
            {
                currency3 = 1.95583;
            }

            if (currency2 == "GBP")
            {
                currency3 = 2.53405;
            }

            double result = 0;
            if (num < currency3)
            {
                result = num * currency3;
            }

            if (num > currency3)
            {
                result = num / currency3;
            }
            var endResult = Math.Round(result, 2);

            Console.WriteLine(endResult + " " + currency2);

        }
    }
}
