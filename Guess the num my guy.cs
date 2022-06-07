using System;

namespace MorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Guess a number between 0 and 100");
                string input = Console.ReadLine();

                if (input == "quit" || input == "end")
                    break;

                int number = Convert.ToInt32(input);

                if (number < 0 || number > 100)
                    Console.WriteLine("Listen to directons my guy!");

                if (number <= 76)
                    Console.WriteLine("You guessed to low my guy!");

                if (number >= 78)
                    Console.WriteLine("You gussed to high my guy!");

                if (number == 77)
                {
                    Console.WriteLine($"You guessed it right! the number was {number} !");
                    break;
                }

            }








        }
    }
}
