using System;
using System.Collections.Generic;

namespace tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Tamabruh (Trademarked by Doofensmith Evil Inc.).");
            Tamagotchi tama = new Tamagotchi();
            while (tama.name == "")
            {
                Console.WriteLine("What would you like to name your new pet?");
                tama.name = Console.ReadLine().Trim();
            }
            Console.WriteLine($"Bruh, so they be named {tama.name}.");

            while (tama.GetAlive())
            {
                Console.WriteLine($"What do you want {tama.name} to do?");
                Console.WriteLine("Would you like to feed them, press 1.");
                Console.WriteLine("Would you like them to talk, press 2.");
                Console.WriteLine("Would you like to teach them a word, press 3 then enter and then type the word.");
                Console.WriteLine("Would you like to see they stats, press 4.");
                string answer = "";
                while (answer != "1" && answer != "2" && answer != "3" && answer != "4")
                {
                    answer = Console.ReadLine();
                }

                // string[] acceptable = {"1", "2", "3", "4"};

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


                // Fråga användaren vad hen vill göra
                // om 1 kör *insert*
            }




            Console.ReadLine();

        }
    }
}

