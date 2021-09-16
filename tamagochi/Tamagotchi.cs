using System;
using System.Collections.Generic;

namespace tamagochi
{
    public class Tamagotchi
    {
        private int Hunger;

        private int Boredom;

        private List<string> words = new List<string>();

        private bool isAlive;

        private Random generator = new Random();

        public string name;

        public void Feed()
        {
            Hunger--;
        }

        public void Hi()
        {

        }

        public void Teach(string word)
        {

        }

        public void Tick()
        {

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
            return true;
        }

        private void ReduceBoredom()
        {

        }
    }
}