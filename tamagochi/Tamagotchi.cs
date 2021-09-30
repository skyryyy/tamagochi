using System;
using System.Collections.Generic;

namespace tamagochi
{
    public class Tamagotchi
    {
        private int Hunger = 2;

        private int Boredom = 2;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        private Random generator = new Random();

        public string name = Console.ReadLine();

        public void Feed()
        {
            Hunger--;

            if (Hunger >= 10 || Boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void Hi()
        {
            if (words.Count == 0)
            {
                Console.WriteLine($"{name} is LITERALLY analphabetic, please teach him a single word before asking him to talk, moron.");
            }
            else
            {
                int i = generator.Next(words.Count);
                Console.WriteLine(words[i]);
            }

            Tick();

            if (Hunger >= 10 || Boredom >= 10)
            {
                isAlive = false;
            }

        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();

            Tick();

            if (Hunger >= 10 || Boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void Tick()
        {
            Hunger++;
            Boredom++;

            if (Hunger >= 10 || Boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            if (isAlive == true)
            {
                Console.WriteLine($"Hunger level is now {Hunger}.");
                Console.WriteLine($"Boredom level is now {Boredom}.");
            }

            if (isAlive == false)
            {
                Console.WriteLine($"The current stats of your beloved pet is dead, you killed {name}, even though they were so young");
            }

            Tick();
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            Boredom--;
        }
    }
}