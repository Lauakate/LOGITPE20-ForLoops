﻿using System;

namespace BackwardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserInput = Console.ReadLine();
            string name = UserInput;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{name[i]}");
            }
        } 
    }
}
