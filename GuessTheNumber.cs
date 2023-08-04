namespace GuessTheNumber
{
    internal class GuessTheNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose difficulty: [e]asy, [m]edium or [h]ard: ");
                string difficulty = Console.ReadLine().ToLower();
                if (difficulty == "e" || difficulty == "easy")
                {
                    Console.WriteLine("Easy difficulty - you have infinite guesses!");
                }
                else if (difficulty == "m" || difficulty == "medium")
                {
                    Console.WriteLine("Medium difficulty - you have 10 guesses!");
                }
                else if (difficulty == "h" || difficulty == "hard")
                {
                    Console.WriteLine("Hard difficulty - you have 5 guesses!");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, 101);
                int guessesCount = 0;
                while (true)
                {
                    Console.Write("Guess the number (1-100): ");
                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int playerNumber);
                    if (isValid)
                    {
                        if (playerNumber == computerNumber)
                        {
                            Console.WriteLine("You guessed it!");
                            break;
                        }
                        else if (playerNumber > computerNumber)
                        {
                            Console.WriteLine("Too high");
                            guessesCount++;
                        }
                        else
                        {
                            Console.WriteLine("Too low");
                            guessesCount++;
                        }

                        if ((difficulty == "m" || difficulty == "medium") && guessesCount >= 10)
                        {
                            Console.WriteLine($"Out of guesses. You lose. The number was {computerNumber}");
                            break;
                        }

                        if ((difficulty == "h" || difficulty == "hard") && guessesCount >= 5)
                        {
                            Console.WriteLine($"Out of guesses. You lose. The number was {computerNumber}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                while (true)
                {
                    Console.Write("Do you want to play again? [yes] [no] ");
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "yes")
                    {
                        break;
                    }
                    else if (playAgain == "no")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Ivalid input");
                        continue;
                    }
                }
            }
        }
    }
}