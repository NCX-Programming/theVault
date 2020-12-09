using System;
using System.Threading;

namespace guessmynumber
{
    class Program
    { 
        public static int guess;
        public static int randomNumber;
        public static int maxNumber = 0;
        public static int maxGuesses = 0;
        public static int usedGuesses = 0;

        static void Main(string[] args)
        {
            // Set ConsoleKey stuff
            ConsoleKeyInfo cki;
            // Program Start
            Console.Clear();
            Console.WriteLine("Welcome to Guess My Number! (theVault Edition)");
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();
            Console.Clear();
            // Main Menu
            Console.WriteLine("Main Menu");
            Console.WriteLine("Select an option by pressing the number on your keyboard.");
            Console.WriteLine("1. Play     2. Game Settings");
            // Read key pressed, using this instead of ReadLine() for speeeeeeeeeeeeeed:tm:
            do
            {
                cki = Console.ReadKey();
                // Play game without setting custom max number (Defaults to 100) or max guesses (Defaults to 10
                if(cki.Key == ConsoleKey.D1) PlayGame();
                // Set custom max number, then start (maybe i should add a limit here because people will go crazy with it)
                if(cki.Key == ConsoleKey.D2) GameSettings();
                if(cki.Key == ConsoleKey.Escape){Console.Clear(); Environment.Exit(0);}
            } while (cki.Key != ConsoleKey.Escape);
        }

        public static void GameSettings() {
            // Set ConsoleKey stuff
            ConsoleKeyInfo cki;
            // Settings menu thing
            Console.Clear();
            Console.WriteLine("Game Settings");
            Console.WriteLine("Select an option by pressing the number on your keyboard.");
            Console.WriteLine("1. Change Max Number     2. Change Max Guesses     3. Play");
            do
            {
                cki = Console.ReadKey();
                // Set custom max number (maybe i should add a limit here because people will go crazy with it)
                if(cki.Key == ConsoleKey.D1) {
                    // Wait for a valid number, must be larger than 1
                    while (maxNumber <= 1) {
                    Console.Clear();
                    Console.WriteLine("Enter the max number, must be positive, larger than 1, and an integer:");
                    maxNumber = Convert.ToInt32(Console.ReadLine());
                    // Output newly set max number and start game
                    Console.Clear();
                    Console.WriteLine("Max number set to " + maxNumber);
                    Thread.Sleep(1500);
                    GameSettings();
                    }
                }
                // Set custom max guess number, if you don't want a limit I guess you could just set this to a stupid high number
                if(cki.Key == ConsoleKey.D2) {
                    // Wait for a valid number, must be larger than 0 (aka no negative numbers)
                    while (maxGuesses <= 0) {
                    Console.Clear();
                    Console.WriteLine("Enter the max number of guesses, must be positive and an integer:");
                    maxGuesses = Convert.ToInt32(Console.ReadLine());
                    // Output newly set max guesses and start game
                    Console.Clear();
                    Console.WriteLine("Max guesses set to " + maxGuesses);
                    Thread.Sleep(1500);
                    GameSettings();
                    }
                }
                if(cki.Key == ConsoleKey.D3) {
                    if(maxGuesses == 0) maxGuesses = 10;
                    if(maxNumber == 0) maxNumber = 100;
                    PlayGame();
                }
                if(cki.Key == ConsoleKey.Escape){Console.Clear(); Environment.Exit(0);}
            } while (cki.Key != ConsoleKey.Escape);
        }

        public class RandomGenerator  
        {  
            // Create random instance
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
            usedGuesses = 0;
            Console.WriteLine("I'm thinking of a number between 1 and " + maxNumber);
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            usedGuesses += 1;
            CheckAnswer();
        }

        public static void CheckAnswer() 
        {
            // Set ConsoleKey stuff
            ConsoleKeyInfo cki;
            // Correct answer
            if(randomNumber == guess) {
                Console.Clear();
                Console.WriteLine("Congratulations! You guessed the right number in " + usedGuesses + " guesses!");
                Console.WriteLine("Play again? y/n");
                do
                {
                    cki = Console.ReadKey();
                    if(cki.Key == ConsoleKey.Y) GameSettings();
                    if(cki.Key == ConsoleKey.N) {Console.Clear(); Environment.Exit(0);}
                } while (cki.Key != ConsoleKey.Escape);
            }
            // Answer too large
            else if(randomNumber < guess) {
                Console.Clear();
                Console.WriteLine("Too large! Try a smaller number.");
                Thread.Sleep(1000);
                GuessAgain();
            }
            // Answer too small
            else if(randomNumber > guess) {
                Console.Clear();
                Console.WriteLine("Too small! Try a larger number.");
                Thread.Sleep(1000);
                GuessAgain();
            }
        }

        public static void GuessAgain()
        {
            // Set ConsoleKey stuff
            ConsoleKeyInfo cki;
            // Obligitory Console.Clear()
            Console.Clear();
            if(usedGuesses == maxGuesses){
                // Out of guesses
                Console.WriteLine("Game Over!");
                Console.WriteLine("You were unable to guess the number in " + maxGuesses + " guesses");
                Console.WriteLine("Play again? y/n");
                do
                {
                    cki = Console.ReadKey();
                    if(cki.Key == ConsoleKey.Y) GameSettings();
                    if(cki.Key == ConsoleKey.N) {Console.Clear(); Environment.Exit(0);}
                } while (cki.Key != ConsoleKey.Escape);
            }
            else {
                // Repeating guessing code
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                usedGuesses += 1;
                CheckAnswer();
            }
        }
    }
}    