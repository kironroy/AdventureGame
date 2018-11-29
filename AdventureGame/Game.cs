using System;
using System.Globalization;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 

namespace AdventureGame
{
    public static class Game
    {

        static int Scenarios = 3;
        //character name
        static string characterName;
        static string characterNameProper;


        // Arrays below (3 total)
        static string[] PartOne = {
            "At the front of the imposing building you see a weathered old man with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a chalk.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\nTo choose type either A for the flashlight, or B for the umbrella.",
            "The power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!",
            "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily " + characterNameProper + " you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you," + characterNameProper + ",\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };
        static string[] PartTwo = {
            "Description of story part two ... and the choice A or B",
            "... part two - what happens if A is chosen...",
            "... part two - what happens if B is chosen...",
            "....more story.... .",
            "... part two, again - what happens if A is chosen...",
            "... part two again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };
        static string[] PartThree = {
            "Description of story part three... and the choice A or B",
            "... part 3 - what happens if A is chosen...",
            "... part 3 - what happens if B is chosen...",
            "....more story.... .",
            "... part 3, again - what happens if A is chosen...",
            "... part 3 again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };
        

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
            Console.WriteLine(); // breakline
        }


        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) print the first part of the section
                        Console.WriteLine(PartOne[0]); // accessing first element in PartOne Array

                        //2)read in player's choice (a or b)
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                        Console.ResetColor();

                        //3) if a print the next part of the array, otherwise skip next and print 3rd
                        if (input == "a") // 
                        {
                            Console.WriteLine(PartOne[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        //4) print next part of the section
                        Console.WriteLine(PartOne[3]);

                        //5) again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        //6) print last piece of the section
                        Console.WriteLine(PartOne[6]);



                        break;

                    case 2:
                        //Part Two

                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }
                        Console.WriteLine(PartTwo[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                        }
                        Console.WriteLine(PartTwo[6]);

                        break;

                    case 3:
                        //Part Three
                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }
                        Console.WriteLine(PartThree[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }
                        Console.WriteLine(PartThree[6]);
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
       




    }
}