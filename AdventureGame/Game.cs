using System;
using System.Globalization;
using System.Collections.Generic;

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
        static List<string> Inventory = new List<string>(); // inventory list

        //ask player for a name, and save it 
        public static void CharacterName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose the name of your character");
            characterName = Console.ReadLine().Trim().ToLower();
            characterNameProper = new CultureInfo("en-US").TextInfo.ToTitleCase(characterName);
            Console.Clear();

            Console.WriteLine($"Hello {characterNameProper}");
            Console.WriteLine(); // breakline
        }


        // 3 
        static string[] PartOne = {
            "At the front of the imposing building you see a weathered old man with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a chalk.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\n\n*** To choose, type either A for the flashlight, or B for the umbrella.",
            "The power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!\n",
            "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you,\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };

        static string[] PartTwo = {
            "The second floor has a black and white checkered floor the same staircase \nand a yellow ladder to another floor\nYou must choose to go up the ladder or use the stairs\n\n*** To choose, type either A to go up the ladder, or B go up the stairs",
            "You climb the ladder and are on the third floor\nYou find a $50 bill on the rung, awesome!", // choice A result
            "\n\nYou choose the stairs, you find a useless shirt button", // choice B result
            "This place is so werid!",
            "The third floor has a International buffet, lucky you have a $50 dollar bill. \nthe buffet is only 10 bucks!",
            "Too bad you chose to the stairs, there was smell of delicious close the ladder",
            "Anyway, you are headed to the fourth floor"
            
            
        };
        static string[] PartThree = {
            "Your on the fourth floor, where there is a pool and a ping pong table. \nDo wanna swim or play ping pong.\n\n*** To choose, Type A for pool B for ping pong",
            "Your in the pool, its sulfuric acid",
            "\n\nYou see there are two paddles and a ball, you gonna play alone?",
            " ",
            "Sulfuric acid means death, YOU ARE DEAD!!!",
            "You play ping pong with an awesome babe ;)",
            " "
        };
        

        //print out game title and overview
        public static void StartGame()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("A roleplaying game");
            Console.WriteLine(); // breakline
            CharacterName(); // calling CharacterName method
            Choice(); // calling Choice method
        }

        public static void EndGame()
        {
            //end of game text

            Console.WriteLine();
            Console.WriteLine($" *** Congratulations {characterNameProper} *** ");
            Console.WriteLine(); // breakline

            Console.WriteLine($" *** You found some items in your journey:");
            Console.WriteLine(); // breakline
            foreach (string item in Inventory)
            {
                Console.WriteLine(" -> " + item);
            }

            if (Inventory.Contains("50 dollar bill"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(); // breakline
                Console.WriteLine(" *** Congratulations you accomplished the goal! You found some money and an awesome babe, nice!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n\n *** But you didn't find any money, terrible!");
            }
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(PartOne[0]); // accessing first element in PartOne Array

                        //2)read in player's choice (a or b)
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                       

                        //3) if a print the next part of the array, otherwise skip next and print 3rd
                        if (input == "a") // 
                        {
                            Console.WriteLine(PartOne[1]);
                            Inventory.Add("flashlight");

                        }
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                            Inventory.Add("umbrella");
                        }

                        //4) print next part of the section
                        Console.WriteLine(PartOne[3]);

                        //5) again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);
                            Inventory.Add("snack");

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
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(PartTwo[0]);
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                     
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                            Inventory.Add("50 dollar bill");

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                            Inventory.Add("shirt button");
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(PartThree[0]);
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();
                    
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                            Inventory.Add("sulfuric acid");

                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                            Inventory.Add("ping pong paddles");
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
                Console.WriteLine(); // breakline
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

                

            }
        }
       
    }
}