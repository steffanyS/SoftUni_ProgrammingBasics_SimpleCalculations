using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert your name: ");
            string name = Console.ReadLine();

            //Console.WriteLine("Greatings {0}!", name);
           // Console.WriteLine($"Greatings {name}!");
            Console.WriteLine("Greatings "+name+"!");
        }
    }
}
