﻿using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int sum = 0;

            for (int i= 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                switch (currentChar)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum+=2;
                        break;
                    case 'i':
                        sum+=3;
                        break;
                    case 'o':
                        sum+=4;
                        break;
                    case 'u':
                        sum+=5;
                        break;

                }

            }

            Console.WriteLine(sum);

        }
    }
}
