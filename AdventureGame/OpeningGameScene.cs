﻿using System;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 
// This work is a derivative of
// "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
// https://creativecommons.org/licenses/by/4.0/

namespace AdventureGame
{
    public static class OpeningGameScene
    {
        public static void ArtTitle()
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.Title = "ASCII Art";
            string title =
                @"


   ▄████████ ████████▄   ▄█    █▄     ▄████████ ███▄▄▄▄       ███     ███    █▄     ▄████████    ▄████████    ▄████████ 
  ███    ███ ███   ▀███ ███    ███   ███    ███ ███▀▀▀██▄ ▀█████████▄ ███    ███   ███    ███   ███    ███   ███    ███ 
  ███    ███ ███    ███ ███    ███   ███    █▀  ███   ███    ▀███▀▀██ ███    ███   ███    ███   ███    █▀    ███    █▀  
  ███    ███ ███    ███ ███    ███  ▄███▄▄▄     ███   ███     ███   ▀ ███    ███  ▄███▄▄▄▄██▀  ▄███▄▄▄       ███        
▀███████████ ███    ███ ███    ███ ▀▀███▀▀▀     ███   ███     ███     ███    ███ ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     ▀███████████ 
  ███    ███ ███    ███ ███    ███   ███    █▄  ███   ███     ███     ███    ███ ▀███████████   ███    █▄           ███ 
  ███    ███ ███   ▄███ ███    ███   ███    ███ ███   ███     ███     ███    ███   ███    ███   ███    ███    ▄█    ███ 
  ███    █▀  ████████▀   ▀██████▀    ██████████  ▀█   █▀     ▄████▀   ████████▀    ███    ███   ██████████  ▄████████▀  
                                                                                   ███    ███                           
";

            Console.WriteLine(title);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                            Press enter to continue...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}