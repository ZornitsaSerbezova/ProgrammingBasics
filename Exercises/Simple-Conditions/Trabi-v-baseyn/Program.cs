﻿using System;

namespace Trabi_v_baseyn
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double water = (p1 * h) + (p2 * h);
            double pfull, pp1, pp2;
            if (water <= v)
            {
                pfull = water / v * 100; // толкова е запълнен басейнът
                pp1 = (p1 * h) / water * 100;
                pp2 = (p2 * h)/ water * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    Math.Truncate(pfull), Math.Truncate(pp1), Math.Truncate(pp2));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, water - v);
            }
            Console.ReadLine();
        }
    }
}
