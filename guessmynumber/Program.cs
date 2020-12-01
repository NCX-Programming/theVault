using System;
using System.Threading;

namespace guessmynumber
{
    class Program
    { 
        public static int guess;
        public static int randomNumber;
        public static string playAgain;
        public static int maxNumber = 0;

        static void Main(string[] args)
        {
            // Program Start
            Console.Clear();
            Console.WriteLine("Welcome to Guess My Number! (theVault Edition)");
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("Select an option by typing the number and pressing enter.");
            Console.WriteLine("1. Play     2. Set Max Number");
            playAgain = Console.ReadLine();
            if (playAgain == "1") {
                maxNumber = 100;
                PlayGame();
                playAgain = "";
            }
            else if (playAgain == "2") {
                while (maxNumber <= 1) {
                    Console.Clear();
                    Console.WriteLine("Enter the max number, must be positive, larger than 1, and an integer:");
                    maxNumber = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Max number set to " + maxNumber);
                Thread.Sleep(1500);
                PlayGame();
                playAgain = "";
            }
        }

        public class RandomGenerator  
        {  
            // Instantiate random number generator.  
            // It is better to keep a single Random instance 
            // and keep using Next on the same instance.  
            private readonly Random _random = new Random();  
  
            // Generates a random number within a range.      
            public int RandomNumber(int min, int max)  
            {  
                return _random.Next(min, max);  
            }  
        }

        public static void PlayGame() {
            // Generates a random integer between 1 and 100
            var generator = new RandomGenerator();  
            randomNumber = generator.RandomNumber(1, maxNumber);

            // Start the game
            Console.Clear();
            Console.WriteLine("I'm thinking of a number between 1 and " + maxNumber);
            Console.WriteLine("Enter your guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            CheckAnswer();
        }

        public static void CheckAnswer() 
        {
            // Correct answer
            if (randomNumber == guess) {
                Console.Clear();
                Console.WriteLine("Congratulations! You guessed the right number!");
                Console.WriteLine("Play again? y/n");
                playAgain = Console.ReadLine();
                if (playAgain == "y") {
                    PlayGame();
                }
                else {
                    Environment.Exit(0);
                }
            }
            // Answer too large
            else if (randomNumber < guess) {
                Console.Clear();
                Console.WriteLine("Too large! Try a smaller number.");
                Thread.Sleep(1000);
                GuessAgain();
            }
            // Answer too small
            else if (randomNumber > guess) {
                Console.Clear();
                Console.WriteLine("Too small! Try a larger number.");
                Thread.Sleep(1000);
                GuessAgain();
            }
        }

        public static void GuessAgain()
        {
            // Repeating guessing code
            Console.Clear();
            Console.WriteLine("Enter your guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            CheckAnswer();
        }
    }
}    