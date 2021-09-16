using System;

namespace tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tamagotchi tama = new Tamagotchi();

            tama.PrintStats();

            Console.ReadLine();

        }
    }
}
