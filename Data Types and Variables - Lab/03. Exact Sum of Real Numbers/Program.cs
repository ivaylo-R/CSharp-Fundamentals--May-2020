﻿using System;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            for (int i = 0; i < n; i++)
            {
                BigInteger currentNum = BigInteger.Parse(Console.ReadLine());
                sum +=currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}