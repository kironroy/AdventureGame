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
        public string name = "Acorn";
        public string description = "pointless.";
        readonly List<string> items = new List<string> { "night", "a compass", "a swiss" };
        readonly List<string> descriptions = new List<string> { "vison glasses", "with a mirror", "army knife" };

        public Item() // ctor contsructor
        {
            // Instantiate random 
            Random randomNumber = new Random(); // Random class is from System;
            int number;

            //Next(Int32) returns a non-negative random number less than the maximum
            number = randomNumber.Next(items.Count);

            name = items[number];
            description = descriptions[number];
            CenterText.centerText($"\n *** In addition, you found {name} {description} \n");
        }
        
    }
}
