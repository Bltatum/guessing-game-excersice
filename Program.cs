using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);

            int guessesGiven = 0;

            Console.WriteLine("Choose Difficulty, Easy, Medium, Hard, Cheater");
            string difficulty = Console.ReadLine();


            while (guessesGiven < 4 && difficulty == "Hard")
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it!");
                    break;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope, too low!");
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope, too high!");
                }

                guessesGiven++;
            }


            while (guessesGiven < 6 && difficulty == "Medium")
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it!");
                    break;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope, too low!");
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope, too high!");
                }

                guessesGiven++;
            }

            while (guessesGiven < 8 && difficulty == "Easy")
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it!");
                    break;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope, too low!");
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope, too high!");
                }

                guessesGiven++;
            }

            while (guessesGiven < 100 && difficulty == "Cheater")
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! you guessed it!");
                    break;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope, too low!");
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope, too high!");
                }

                guessesGiven++;
            }
        }
    }
}