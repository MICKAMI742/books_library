using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace books_library
{
    class Program
    {
        static void Main(string[] args)
        {
            // defines which function is going to happen
            bool programState = true;
            Library myLibrary = new Library();
            while (programState)
            {
                Console.WriteLine("Welcome to library\n" +
                    "You need to click expected button to follow the function:\n" +
                    "\tESC - exit the program\n" +
                    "\t1 - login to library attendant panel\n" +
                    "\t2 - create your library account" 
                    );
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.Escape:
                        programState = false;
                        break;
                    case ConsoleKey.D1:
                        myLibrary.LogIn(myLibrary);
                        break;
                    case ConsoleKey.D2:
                        myLibrary.CreateAccount();
                        break;
                    default:
                        Console.WriteLine("You clicked wrong button");
                        break;
                }
            }
        }
    }
}

