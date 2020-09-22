using System;

namespace AinString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string UserInput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            for (int i = 0; i < UserInput.Length; i++)
            {
                if (UserInput.ToLower()[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"There are {counter} As in your text");

            }
            else
            {
                Console.WriteLine($"There are no As in your text");
            }
        }
    }
}
