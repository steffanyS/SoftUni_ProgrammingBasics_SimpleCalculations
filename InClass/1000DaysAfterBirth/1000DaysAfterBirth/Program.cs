﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date.AddDays(1000));
        }
    }
}
