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
            Console.WriteLine("==============================");
            Console.WriteLine("|      'Graphics' Test       |");
            Console.WriteLine("|          theVault          |");
            Console.WriteLine("|                            |");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.WriteLine("|  Press any key to continue |");
            Console.ResetColor();
            Console.WriteLine("|                            |");
            Console.WriteLine("|     © NinjaCheetah 2020    |");
            Console.WriteLine("==============================");   
            Console.ReadKey();
            Menu();
        }

        public static void Menu() {
            Console.Clear();
            // Draw example selection menu
            Console.WriteLine("============================================================");
            Console.WriteLine("| Choose an example to try:                                |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Color Test                                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 2. Menu Style Test (WIP)                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 3. Misc Things I tried to 'draw' (WIP)                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 4. About                                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 5. Exit                                                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("============================================================");
            // Read selection
            menuSelection = Convert.ToInt32(Console.ReadLine());
            switch (menuSelection) {
                case 1:
                    Colors();
                    break;
                case 2:
                    Menu();
                    break;
                case 3:
                    Menu();
                    break;
                case 4:
                    About();
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void About() {
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
            // Send each available color
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
            Console.WriteLine("Foreground (text) colors:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach(var color in consoleColors) {
                Console.ForegroundColor = color;
                Console.WriteLine(color);
            }
            Thread.Sleep(1500);
            Console.ResetColor();
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
            Menu();
        }
    }
}