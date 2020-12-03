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
            Console.WriteLine("| Choose an example to try                                 |");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|                                                          |");
            Console.ResetColor();
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Color Test                                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 2. Menu Style Test (WIP)                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 3. Misc Things I tried to 'draw' (WIP)                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 4. *insert fourth option here*                           |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 5. About                                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("============================================================");
            // Read selection
            menuSelection = Convert.ToInt32(Console.ReadLine());
            switch (menuSelection) {
                case 1:
                    Menu();
                    break;
                case 2:
                    Menu();
                    break;
                case 3:
                    Menu();
                    break;
                case 4:
                    Menu();
                    break;
                case 5:
                    About();
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
    }
}