﻿using System;
using OasysUnitsNet;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Length: " + Length.FromMeters(1));
            Console.ReadKey(true);
        }
    }
}
