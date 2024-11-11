using System;
using System.Reflection.Metadata.Ecma335;

namespace books_library
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programState = true;
            while (programState)
            {
                Library myLibrary = new Library();
                Console.WriteLine("Welcome to library\n" +
                    "You need to click expected button to follow the function:\n" +
                    "\tESC - exit the program\n" +
                    "\t1 - login to library attendant panel\n" +
                    "\t2 - login to library admin panel\n" +
                    "\t3 - create your library account" 
                    );
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.Escape:
                        programState = false;
                        break;
                    case ConsoleKey.D1:
                        Console.WriteLine("You are logged in as library attendant");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("You are logged in as library admin");
                        myLibrary.ShowBooks();
                        myLibrary.ShowUsers();
                        break;
                    case ConsoleKey.D3:
                        Library.CreateAccount();
                        break;
                    default:
                        Console.WriteLine("You clicked wrong button");
                        break;
                }
            }
        }
    }
}

