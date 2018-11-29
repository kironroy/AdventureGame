using System;
using System.Globalization;
using System.Collections.Generic;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 
// This work is a derivative of
// "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
// https://creativecommons.org/licenses/by/4.0/

namespace AdventureGame
{
    public static class EndingGameScene
    {
        public static void EndTitle()
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string title =
                @"
                               
                     
                                                        ███████╗██╗███╗   ██╗
                                                        ██╔════╝██║████╗  ██║
                                                        █████╗  ██║██╔██╗ ██║
                                                        ██╔══╝  ██║██║╚██╗██║
                                                        ██║     ██║██║ ╚████║
                                                        ╚═╝     ╚═╝╚═╝  ╚═══╝
                     
        
                                                                                              

                                                       

                ";

            Console.WriteLine(title);
            Console.ReadKey();
            Console.Clear();


        }
    }
}
