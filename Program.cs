using System;

namespace RandomNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,100);
            Console.WriteLine("Pick a number from 1 to 100.");
            var input = int.Parse(Console.ReadLine()); 
            while (input != number)
            {
                if (input > number)
                {
                    Console.WriteLine("Your guess is too high.");
                    input = int.Parse(Console.ReadLine());
                } else if (input < number)
                {
                    Console.WriteLine("Your guess is too low.");
                    input = int.Parse(Console.ReadLine());
                }  
            }
            if (input == number)
            {
                Console.WriteLine("You guessed correctly");
            }
        }
    }
}
