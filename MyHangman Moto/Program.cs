using System;

namespace MyHangman_Moto
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] guessedWord;
            char letter;
            int wrongLetterCnt = 0;

            Console.WriteLine("The Hangman game");
            Console.WriteLine("Write player name");

            string playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName);

            //getting the secret word
            Console.WriteLine("Rules are simple. You guess the secret word by guessing single letters. You may make only 5 mistakes.");
            Console.WriteLine("First, ask someone to write the secret word - don't look! :)");

            string secretWord = Console.ReadLine().ToLower();

            //hiding the secret word under dashes
            guessedWord = new char[secretWord.Length];

            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            while (true)
            {
                //start of game, getting letters from player
                Console.Clear();
                Console.WriteLine(guessedWord);

                Console.WriteLine("Start typing letters and hit 'enter' to guess the secret word. Lives left: " + (5 - wrongLetterCnt) + " Good luck!");

                letter = Console.ReadLine().ToLower()[0];

                Console.WriteLine("Your letter: " + letter);

                //help mark whether player put wrong letter
                bool isWrongLetter = true;

                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (letter == secretWord[i])
                    {
                        guessedWord[i] = letter;
                        isWrongLetter = false;
                    }
                }

                if (isWrongLetter)
                {
                    wrongLetterCnt++;
                }

                bool isEnd = true;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (guessedWord[i] == '_')
                    {
                        isEnd = false;
                        break;
                    }
                }
                    if (isEnd)
                {
                    break;
                    //break from while loop
                    
                }
                //end of game statement
                if (wrongLetterCnt >= 5)
                {
                    Console.WriteLine("You've lost the game... The secret word was: " + secretWord);
                    Console.WriteLine("+--------+---");
                    Console.WriteLine("|        |   ");
                    Console.WriteLine("|        O   ");
                    Console.WriteLine("|       /|\\ ");
                    Console.WriteLine("|        |   ");
                    Console.WriteLine("|       / \\ ");
                    Console.WriteLine("|\\          ");
                    Console.WriteLine("| \\         ");
                    Console.ReadLine();
                    return;

                }

            }

            Console.Clear();
            Console.WriteLine("Congratulations, you finally guessed the secret word! The secret word was: " + secretWord);
            Console.WriteLine("Press enter to end game");
            Console.ReadLine();
        }
    }
}
