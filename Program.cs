﻿using System;

namespace C_Sharp_Random_Numbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            var randomNumber = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int j = randomNumber.Next(1, 100);
                Console.WriteLine(j);
            }
        }
    }
}
