using System;
using System.Collections.Generic;

namespace tamagochi
{
    public class Tamagotchi
    {
        private int Hunger;

        private int Boredom;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        private Random generator = new Random();

        public string name;

        public void Feed()
        {
            Hunger--;
        }

        public void Hi()
        {
            if (words.Count == 0)
            {
                Console.WriteLine($"{name} is LITERALLY analphabetic, please teach him a single word before asking him to talk moron.");
            }
            else
            {
                int i = generator.Next(words.Count);
                Console.WriteLine(words[i]);
            }

        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            Hunger++;
            Boredom++;
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