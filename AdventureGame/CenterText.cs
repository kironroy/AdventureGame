using System;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 
// This work is a derivative of
// "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
// https://creativecommons.org/licenses/by/4.0/
// https://stackoverflow.com/questions/10286056/what-is-the-command-to-exit-a-console-application-in-c

namespace AdventureGame
{
    class CenterText
    {
        public static void centerText(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine("\n");


            Console.WriteLine(message.PadLeft(spaces));
        }

    }
}
