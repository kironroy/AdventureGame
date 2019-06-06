using System;
using System.Globalization;
using System.Collections.Generic;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 

namespace AdventureGame
{
    public class MainGame
    {

        int Scenarios = 3;
        string characterName;
        string characterNameProper;
        readonly List<string> inventory = new List<string>(); // inventory list

        //ask player for a name, and save it 
        private void CharacterName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText.centerText("Choose the name of your character");
            characterName = Console.ReadLine().Trim().ToLower();
            characterNameProper = new CultureInfo("en-US").TextInfo.ToTitleCase(characterName);
            Console.Clear();

            CenterText.centerText($"Hello {characterNameProper}");
            "".PrintToConsole(); // breakline
        }

        // Three parts to story 

        //print out game title and overview
        public void StartGame()
        {
            //Console.ForegroundColor = ConsoleColor.Green;

            CenterText.centerText("A roleplaying game");
            "".PrintToConsole(); // breakline
            CharacterName(); // calling CharacterName method
            Choice(); // calling Choice method
        }

        public void EndGame()
        {
            //end of game text

            Console.WriteLine();
            CenterText.centerText($" *** Congratulations {characterNameProper} *** ");
            "".PrintToConsole(); // breakline

            CenterText.centerText($" *** You found some items in your journey:");
            "".PrintToConsole(); // breakline
            foreach (string item in inventory)
            {
                CenterText.centerText(" -> " + item);
            }

            if (inventory.Contains("50 dollar bill"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                "".PrintToConsole(); // breakline
                CenterText.centerText(" *** Congratulations you accomplished the goal! You found some money and an awesome babe, nice!");
                Console.ResetColor();
            }
            else
            {
                CenterText.centerText("\n\n *** But you didn't find any money, terrible!");
            }
        }

        public void Choice()
        {
            List<string> partOne = new List<string>
            {
                "At the front of the imposing building you see a weathered old man with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a chalk.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\n\n*** To choose, type either A for the flashlight, or B for the umbrella.",
                "\nThe power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!\n",
                "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
                "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
                "Luckily you have that coin you found and you buy yourself a snack.",
                "Too bad you don't have a coin on you,\nor you would have been able to get a snack.",
                "You begin to climb the stairs to the next floor."
            };



            List<string> partTwo = new List<string>
            {
                "The second floor has a black and white checkered floor the same staircase \nand a yellow ladder to another floor\nYou must choose to go up the ladder or use the stairs\n\n*** To choose, type either A to go up the ladder, or B go up the stairs",
                "\nYou climb the ladder and are on the third floor\nYou find a $50 bill on the rung, awesome!", // choice A result
                "\n\nYou choose the stairs, you find a useless shirt button", // choice B result
                "This place is so werid!",
                "The third floor has a International buffet, lucky you have a $50 dollar bill. \nthe buffet is only 10 bucks!",
                "Too bad you chose to the stairs, there was smell of delicious close the ladder",
                "Anyway, you are headed to the fourth floor"
            };



            List<string> partThree = new List<string>
            {
                "Your on the fourth floor, where there is a pool and a ping pong table. \nDo wanna swim or play ping pong.\n\n*** To choose, Type A for pool B for ping pong",
                "Your in the pool, its sulfuric acid",
                "\n\nYou see there are two paddles and a ball, you gonna play alone?",
                " ",
                "Sulfuric acid means death, YOU ARE DEAD!!!",
                "No! You play ping pong with an awesome babe ;)",
                " "
            };


            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) print the first part of the section
                        Console.ForegroundColor = ConsoleColor.Green;
                        partOne[0].PrintToConsole(); // accessing first element in PartOne Array

                        //2)read in player's choice (a or b)
                        "".PrintToConsole(); // breakline
                        "Enter your choice: ".PrintToConsole();
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();


                        //3) if a print the next part of the array, otherwise skip next and print 3rd
                        if (input == "a") // 
                        {
                            "".PrintToConsole(); // breakline
                            partOne[1].PrintToConsole();
                            inventory.Add("flashlight");

                        }
                        else
                        {
                            "".PrintToConsole(); // breakline
                            partOne[2].PrintToConsole();
                            inventory.Add("umbrella");
                        }

                        //4) print next part of the section
                            partOne[3].PrintToConsole();

                        //5) again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            "".PrintToConsole(); // breakline
                            partOne[4].PrintToConsole();
                            inventory.Add("snack");

                        }
                        else
                        {
                            "".PrintToConsole(); // breakline
                            partOne[5].PrintToConsole();
                        }

                        //6) print last piece of the section
                        Console.WriteLine(partOne[6]);



                        break;

                    case 2:
                        //Part Two
                        Console.ForegroundColor = ConsoleColor.Blue;
                        partTwo[0].PrintToConsole();
                        "Enter your choice: ".PrintToConsole();
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();

                        if (input == "a")
                        {
                            Console.WriteLine(partTwo[1]);
                            inventory.Add("50 dollar bill");

                        }
                        else
                        {
                            partTwo[2].PrintToConsole();
                            inventory.Add("shirt button");
                        }
                            partTwo[3].PrintToConsole();
                        if (input == "a")
                        {
                            partTwo[4].PrintToConsole();

                        }
                        else
                        {
                            partTwo[5].PrintToConsole();
                        }
                        Console.WriteLine(partTwo[6]);

                        break;

                    case 3:
                        //Part Three
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        partThree[0].PrintToConsole();
                        "Enter your choice: ".PrintToConsole();
                        input = Console.ReadLine();
                        input = input.Trim().ToLower();

                        if (input == "a")
                        {
                            partThree[1].PrintToConsole();
                            inventory.Add("sulfuric acid");

                        }
                        else
                        {
                            partThree[2].PrintToConsole();
                            inventory.Add("ping pong paddles");
                        }
                            partThree[3].PrintToConsole();
                        if (input == "a")
                        {
                            partThree[4].PrintToConsole();

                        }
                        else
                        {
                            partThree[5].PrintToConsole();
                        }
                            partThree[6].PrintToConsole();
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                "".PrintToConsole(); // breakline
                "Press enter to continue...".PrintToConsole();
                Console.ReadKey();
                Console.Clear();



            }

        }
    }
}