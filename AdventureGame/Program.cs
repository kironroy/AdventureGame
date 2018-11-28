using System;
using System.Globalization;

// 1. class Program
// 2. class Console -> WriteLine is a method 

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
            string characterName;
            string characterNameProper;

            Console.WriteLine("Adventures of Archie");
            Console.WriteLine("A roleplaying game");

            Console.WriteLine("Choose the name of your character");
            characterName = Console.ReadLine().Trim();
            characterNameProper = new CultureInfo("en-US").TextInfo.ToTitleCase(characterName);
            Console.WriteLine($"You chose {characterNameProper} as your name");

            Console.ReadKey();
        }
    }
}
