using System;
using System.Globalization;

// http://programmingisfun.com/learn/c-sharp-adventure-game/
// 1. class Program
// 2. class Console -> WriteLine is a method of console class 
// This work is a derivative of
// "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
// https://creativecommons.org/licenses/by/4.0/

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {

            OpeningGameScene.ArtTitle();

            Game.StartGame();  // class Game . operator  using Start Game method

            Game.EndGame();

            var items = new Item();

            EndingGameScene.EndTitle();

        }
    }
}
