using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 100; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer");
                Console.WriteLine("Take one down, pass it around");
                
            }

        }
    }
}
