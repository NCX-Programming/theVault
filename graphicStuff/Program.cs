using System;
using System.Threading;

namespace graphicStuff
{
    class Program
    { 
        public static int menuSelection;
        
        static void Main(string[] args)
        {
            Console.Clear();
            // Draw main screen
            Console.ResetColor();
            Console.WriteLine("===============================");
            Console.WriteLine("|       'Graphics' Test       |");
            Console.WriteLine("|           theVault          |");
            Console.WriteLine("|                             |");
            // White highlighted section
            Console.Write("|  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Press any key to continue");
            Console.ResetColor();
            Console.WriteLine("  |");
            // End of white highlighted section
            Console.ResetColor();
            Console.WriteLine("|                             |");
            Console.WriteLine("|     © NinjaCheetah 2020     |");
            Console.WriteLine("===============================");   
            Console.ReadKey();
            Menu();
        }

        public static void Menu() {
            // Set key thing to make it easier to read key input (idk it's from ms docs)
            ConsoleKeyInfo cki;
            // Draw example selection menu
            Console.Clear();
            Console.WriteLine("============================================================");
            Console.WriteLine("| Choose an example to try:                                |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Color Test                                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 2. Menu Style Test (WIP, but functional)                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 3. Misc Things I tried to 'draw' (WIP)                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 4. About                                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 5. Exit                                                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("============================================================");
            // Read selection, now with effeciency:tm: (but not with spelling aparently)
            do
            {
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.D1) Colors();
                if(cki.Key == ConsoleKey.D2) MenuTests();
                if(cki.Key == ConsoleKey.D3) Menu();
                if(cki.Key == ConsoleKey.D4) About();
                if(cki.Key == ConsoleKey.D5){Console.Clear(); Environment.Exit(0);}
            } while (cki.Key != ConsoleKey.Escape);
        }

        public static void About() {
            // Draw about screen
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("|      'Graphics' Test       |");
            Console.WriteLine("|          theVault          |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|     © NinjaCheetah 2020    |");
            Console.WriteLine("|         © NCX 2020         |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|    Some rights reserved,   |");
            Console.WriteLine("|   see Legal for more info  |");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Legal    2. Menu");
            // Read menu selection
            menuSelection = Convert.ToInt32(Console.ReadLine());
            switch (menuSelection) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You are free to use anything from this project, such as the menu examples, minus 'theVault' branding. Crediting is NOT required. ");
                    Thread.Sleep(2500);
                    Console.WriteLine("Press any key to return to the menu.");
                    Console.ReadKey();
                    Menu();
                    break;
                case 2:
                    Menu();
                    break;
            }
        }

        public static void Colors() {
            Console.Clear();
            // Get list of all available colors
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor .GetValues(typeof(ConsoleColor));
            // Send each available background color
            Console.WriteLine("Background colors:");
            Console.ForegroundColor = ConsoleColor.Black;
            foreach(var color in consoleColors) {
                Console.BackgroundColor = color;
                Console.WriteLine(color); 
            }
            Thread.Sleep(1500);
            Console.ResetColor();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            // Send every available foreground color
            Console.WriteLine("Foreground (text) colors:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach(var color in consoleColors) {
                Console.ForegroundColor = color;
                Console.WriteLine(color);
            }
            Thread.Sleep(1500);
            Console.ResetColor();
            // Prompt for return to menu
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
            Menu();
        }

        public static void MenuTests() {
            // Introduce example 1
            Console.Clear();
            Console.WriteLine("Example 1, a message box");
            Thread.Sleep(1500);
            // Draw example 1
            Console.Clear();
            Console.WriteLine(" *====================================*");
            Console.WriteLine(" |            Message Box             |");
            Console.WriteLine(" *====================================*");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |         I'm a message box!         |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |  1. Ok                  2. Cancel  |");
            Console.WriteLine(" *====================================*");
            // Wait briefly, and then prompt to continue
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            // Introduce example 2
            Console.Clear();
            Console.WriteLine("Example 2, a selection menu");
            Thread.Sleep(1500);
            // Draw example 2
            Console.Clear();
            Console.WriteLine(" *====================================*");
            Console.WriteLine(" | Example Title                      |");
            Console.WriteLine(" *=======*============================*");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (1)  |   Example Item 1           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (2)  |   Example Item 2           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (3)  |   Example Item 3           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (4)  |   Example Item 4           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (5)  |   Example Item 5           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (6)  |   Example Item 6           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" |  (7)  |   Example Item 7           |");
            Console.WriteLine(" |       |                            |");
            Console.WriteLine(" *=======*============================*");
            // Wait briefly, and then prompt to continue
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();
        }
    }
}