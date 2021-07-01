using System;

namespace MyHangman_Moto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The very first Hangman");
            Console.WriteLine("Player name");

            string playerName = Console.ReadLine();
            Console.WriteLine("Witaj " + playerName);

            Console.WriteLine("Rules are simple. You guess the secret word by guessing single letters.");
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Leaderboard");
            Console.WriteLine("3. End");

            Console.ReadLine();
        }
    }
}
