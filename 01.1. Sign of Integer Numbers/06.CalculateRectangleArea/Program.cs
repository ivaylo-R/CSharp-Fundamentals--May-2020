﻿using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double Area = GetRectangleArea(width, height);
            Console.WriteLine(Area);
        }
        public static double GetRectangleArea(double width,double height)
        {
            return width * height;
        }
    }
}
