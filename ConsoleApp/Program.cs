﻿using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in System.Linq.Enumerable.Range(1, 50))
                Console.WriteLine("Hello World!");
        }
    }
}
