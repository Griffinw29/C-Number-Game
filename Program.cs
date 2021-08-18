using System;


namespace NumberGuesser
{
    class Program
    {

        static void Main(string[] args)
        {
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Will Griffin";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name? Why have you chosen to disturb my slumber?!?!?!");

            string playerName = Console.ReadLine();

            Console.WriteLine("I'll make you a deal {0}. Guess the number i am thinking of and i will let you live. If you guess wrong i will eat" + " you for a midnight snack then go back to sleeping peacefully. No pressure! MUAHAHAHAHAHAHAHA!! ", playerName);

            while (true)
            {

                //int correctNumber = 7;

                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess the number i am thinking of. It's between 1 and 10. Good luck...youre going to need it!");

                while (guess != correctNumber)
                {
                    string playerGuess = Console.ReadLine();

                    if (!int.TryParse(playerGuess, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("At least use numbers and not any other characters your fool!");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(playerGuess);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WRONG! Try not to fail miserably this time...");
                        Console.ResetColor();
                    }







                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Look at that...you actually guessed correctly. Be gone! You were boring me anyways. Safe travels {0}", playerName);
                Console.ResetColor();

                Console.WriteLine("Temp the Elder Dragon again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                
            }


        }
    }
}
