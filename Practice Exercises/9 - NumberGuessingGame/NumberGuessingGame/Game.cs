/*
 * The purpose of Games.cs is to set up the guessing game as an object
 * 
 * Author: Kyle James
 * Version: 9/18/2019
 * NOTES:   - How the guessing increments are handled and checked should be made more efficient.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Game
    {
        // Declare fields
        private ConsoleColor correct = ConsoleColor.Green;
        private ConsoleColor error = ConsoleColor.DarkRed;
        private ConsoleColor high = ConsoleColor.Blue;
        private int allowedGuesses;
        private int guesses;
        private int targetNumber;
        private Random generator;

        // Constructors
        public Game(Random rng)
        {
            generator = rng;
            SetGame();
        }

        // Methods
        public void PlayGame()
        {
            // Temporary local variables
            bool gameOver;
            bool isValid;
            bool play = true;
            string userInput;

            while (play)
            {
                SetGame();
                //Console.WriteLine(targetNumber); // Error checking
                isValid = false;
                gameOver = false;

                while (!gameOver)
                {
                    gameOver = IsGameOver(PromptForGuess());
                }

                while (!isValid)
                {
                    Console.Write("Would you like to play again (Y/N)?: ");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    Console.WriteLine();

                    switch (userInput)
                    {
                        case "y":
                            isValid = true;
                            break;
                        case "n":
                            play = false;
                            isValid = true;
                            Console.WriteLine("Thanks for playing!\n");
                            break;
                        default:
                            Console.Write("That was not a valid response.\n");
                            break;
                    }
                }
            }
        }

        private int PromptForGuess()
        {
            // Temporary local variables
            bool isValidEntry;
            string userInput;

            // Makes sure it doesn't print out turn #9
            if (guesses + 1 > allowedGuesses)
            {
                return -1;
            }

            // Ask user for a guess
            Console.Write($"Turn #{guesses + 1}: Enter your guess: ");
            userInput = Console.ReadLine();
            isValidEntry = int.TryParse(userInput, out int guess);

            // Check if guess is valid
            while (!isValidEntry || guess < 0 || guess > 100)
            {
                Console.ForegroundColor = error;
                Console.WriteLine("Invalid guess - try again");
                Console.ResetColor();

                // Reprompt if not valid
                Console.Write($"Turn #{guesses + 1}: Enter your guess: ");
                userInput = Console.ReadLine();
                isValidEntry = int.TryParse(userInput, out guess);
            }

            return guess;
        }

        private bool IsGameOver(int currentGuess)
        {
            // Check if the guesses violates the number of allowed guesses
            guesses++;
            if (guesses > allowedGuesses)
            {
                Console.ForegroundColor = error;
                Console.WriteLine($"Game over: You ran out of turns. The number was {targetNumber}.\n");
                Console.ResetColor();
                return true;
            }
            else
            {
                // Check users guess
                if (currentGuess > targetNumber)
                {
                    Console.ForegroundColor = high;
                    Console.WriteLine("Too high\n");
                    Console.ResetColor();
                    return false;
                }
                else if (currentGuess < targetNumber)
                {
                    Console.ForegroundColor = error;
                    Console.WriteLine("Too low\n");
                    Console.ResetColor();
                    return false;
                }
                else if (currentGuess == targetNumber)
                {
                    Console.ForegroundColor = correct;
                    Console.WriteLine($"Correct! You won in {guesses} turns.\n");
                    Console.ResetColor();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void SetGame()
        {
            allowedGuesses = 8;
            guesses = 0;
            targetNumber = generator.Next(100);
        }
    }
}
