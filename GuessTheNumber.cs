namespace GuessTheNumber
{
    internal class GuessTheNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, 101);
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
                        }
                        else
                        {
                            Console.WriteLine("Too low");
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