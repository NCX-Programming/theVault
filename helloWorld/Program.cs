using System;
using System.Threading;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            Console.WriteLine("The time is " + DateTime.Now);
            Thread.Sleep(1000);
            Console.WriteLine("Though you probably already knew that");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("The time is " + DateTime.Now);
            Console.WriteLine("Though you probably already knew that.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("The time is " + DateTime.Now);
            Console.WriteLine("Though you probably already knew that..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("The time is " + DateTime.Now);
            Console.WriteLine("Though you probably already knew that...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Anyway, welcome to theVault! I hope you enjoy all the programs here!");
            Console.WriteLine("All Vault programs Copyright NinjaCheetah 2020");
            Thread.Sleep(2000);
            Console.WriteLine("(Press any key to exit)");
            Console.ReadKey();
        }
    }
}
