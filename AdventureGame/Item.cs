using System;
using System.Globalization;
using System.Collections.Generic;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 

namespace AdventureGame
{
    public class Item
    {
        //default is a stone
        public string Name = "Acorn";
        public string Description = "pointless.";

        string[] Items = { "night", "a compass", "a swiss" };
        string[] Descriptions = { "vison glasses", "with a mirror", "army knife" };

        public Item() // ctor contsructor
        {
            // Instantiate random 
            Random randomNumber = new Random(); // Random class is from System;
            int number;

            //Next(Int32) returns a non-negative random number less than the maximum
            number = randomNumber.Next(Items.Length);

            Name = Items[number];
            Description = Descriptions[number];
            Console.Write($"\n *** In addition, you found {Name} {Description} \n");
        }
        
    }
}
