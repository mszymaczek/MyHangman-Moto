using System;

namespace MyHangman_Moto
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] guessedWord;
            char letter;

            Console.WriteLine("The very first Hangman");
            Console.WriteLine("Write player name");

            string playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName);

            Console.WriteLine("Rules are simple. You guess the secret word by guessing single letters.");
            Console.WriteLine("Ask someone to write the secret word - don't look! :)");

            string secretWord = Console.ReadLine();

            guessedWord = new char[secretWord.Length];

            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord[i] = '_';
            }
            Console.Clear();
            Console.WriteLine(guessedWord);

            Console.WriteLine("Start typing letters to guess the secret word. Good luck!");

            letter = Console.ReadLine()[0];

            Console.WriteLine("Your letter: " + letter);

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter == secretWord[i]) 
                {
                    guessedWord[i] = letter;
                }
            }

            Console.Clear();
            Console.WriteLine(guessedWord);


        }
    }
}
