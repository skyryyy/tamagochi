using System;
using System.Collections.Generic;

namespace tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tama = new Tamagotchi();

            Console.WriteLine("Welcome to Tamabruh (Trademarked by Doofensmith Evil Inc.).");
            Console.WriteLine("What would you like to name your new pet?");
            string name = Console.ReadLine();
            Console.WriteLine($"Bruh, so they be named {name}.");

            while (tama.GetAlive())
            {
                Console.WriteLine($"What do you want {name} to do?");
                Console.WriteLine("Would you like to feed them, press 1. Would you like them to talk, press 2. Would you like to teach them a word, press 3. Would you like to see they stats, press 4.");
                string answer = Console.ReadLine();

                // string[] acceptable = {"1", "2", "3", "4"};

                while (answer == "1" || answer == "2" || answer == "3" || answer == "4")
                {
                    if (answer == "1")
                    {
                        tama.Feed();
                    }

                    else if (answer == "2")
                    {
                        tama.Hi();
                    }

                    else if (answer == "3")
                    {
                        tama.Teach(Console.ReadLine());
                    }

                    else if (answer == "4")
                    {
                        tama.PrintStats();
                    }

                    else
                    {
                        Console.WriteLine("Bruh, you stoopid, press one the keys");
                    }
                }

                // Fråga användaren vad hen vill göra
                // om 1 kör *insert*
            }




            Console.ReadLine();

        }
    }
}
