using System;
using System.Collections.Generic;

namespace Exercise8_Hangman
{
    internal class Program
    {
        static void Main()
        {
            bool playAgain = true;

            while (playAgain)
            {
                HangmanGame();
                Console.Write("Play again? (y/n): ");
                playAgain = Console.ReadLine().Trim().ToLower() == "y";
                Console.Clear();
            }
        }

        static void HangmanGame()
        {
            string[] words = { "codelex", "microsoft", "programming", "backend", "developer" };
            Random random = new Random();
            string word = words[random.Next(words.Length)];
            char[] guessedLetters = new string('_', word.Length).ToCharArray();
            List<char> missedLetters = new List<char>(); 

            int maxGuesses = word.Length;
            int correctGuesses = 0;
            int incorrectGuesses = 0;

            int playerPoints = 0;
            int pointsPerWinGuess = 3;

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine($"The word has {word.Length} letters. Try to guess it!");

            while (incorrectGuesses < maxGuesses)
            {
                Console.WriteLine($"Attempts: {maxGuesses - incorrectGuesses}");
                Console.WriteLine($"Current: {GetDisplayWord(guessedLetters)}");
                Console.WriteLine($"Missed: {string.Join(" ", missedLetters)}"); 

                Console.Write("Enter a letter: ");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput.Length != 1 || !char.IsLetter(userInput[0]))
                {
                    Console.WriteLine("Enter single letter.");
                    continue;
                }

                char guessedLetter = userInput[0];
                bool found = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guessedLetter && guessedLetters[i] == '_')
                    {
                        guessedLetters[i] = guessedLetter;
                        found = true;
                        correctGuesses++;
                        playerPoints += pointsPerWinGuess + word.Length / 2;
                    }
                }

                if (correctGuesses == word.Length)
                {
                    Console.WriteLine($"Congratulations! You guessed word: {word.ToUpper()}. And win {playerPoints} points");
                    return;
                }

                if (!found)
                {
                    Console.WriteLine($"The letter '{guessedLetter}' is not in the word.");
                    incorrectGuesses++;
                    missedLetters.Add(guessedLetter); 
                }
            }

            Console.WriteLine($"Sorry, you lose! The word was: {word.ToUpper()}");
        }
        static string GetDisplayWord(char[] guessedLetters)
        {
            return string.Join(" ", guessedLetters);
        }
    }
}
