using System;
using System.Globalization;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 

namespace AdventureGame
{
    public static class Game
    {
        //character name
        static string characterName;
        static string characterNameProper;

        //print out game title and overview
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Adventures of Archie ***");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A roleplaying game");
            Console.WriteLine(); // breakline
            CharacterName(); // calling CharacterName method
            Choice(); // calling Choice method
        }

        //ask player for a name, and save it 
        public static void CharacterName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose the name of your character");
            characterName = Console.ReadLine().Trim();
            characterNameProper = new CultureInfo("en-US").TextInfo.ToTitleCase(characterName);
            Console.WriteLine($"You chose {characterNameProper} as your name");
        }


        public static void Choice()
        {

            string characterInput = " ";
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello {characterNameProper}, which path do you wanna choose: A or B?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            characterInput = Console.ReadLine().Trim().ToUpper();
            if (characterInput == "A")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }

        }

      


    }
}