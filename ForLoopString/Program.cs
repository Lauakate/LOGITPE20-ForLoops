using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Peeter";
            Console.WriteLine("What is your name?");
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i}. {name[i]}");
            }
        }
    }
}
