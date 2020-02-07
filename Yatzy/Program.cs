using System;
using System.Collections.Generic;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            //YatzyPlayer player1 = new YatzyPlayer("Peter");
            //YatzyPlayer player2 = new YatzyPlayer("Dennis");
            YatzyGame yatzyGame = new YatzyGame(2);
            GameManager gameManager = new GameManager();
            yatzyGame.checkDiceEvent += YatzyGame_checkDice;
            yatzyGame.LockPlayerDiceEvent += YatzyGame_LockPlayerDiceEvent;

            gameManager.GeneratePlayers(yatzyGame.PlayerAmount);

            while (true)
            {
                yatzyGame.Play(gameManager.currentPlayers);
            }
        }

        //This method does too much
        private static List<Dice> YatzyGame_LockPlayerDiceEvent(YatzyPlayer player)
        {
            string input = "";
            Console.WriteLine("Keep any dice?");
            while (true)
            {
                input = Console.ReadLine().ToLower();
                if (!string.IsNullOrWhiteSpace(input))
                    break;
            }
            //Checks if you want to keep any dice
            switch (input)
            {
                case "yes":
                    break;
                case "y":
                    break;
                case "no":
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }

            Console.WriteLine("what dice #'s would you like to keep?(index)");
            //Keep Dice method
            KeepDice(input);
            return player.playerDice;
        }
        //This should be somewhere else
        //Maybe GameManager or player?
        private static void KeepDice(string input)
        {
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Checks what values <paramref name="player"/>'s dice have
        /// </summary>
        /// <param name="player"></param>
        private static void YatzyGame_checkDice(YatzyPlayer player)
        {
            Console.WriteLine(player.Name + " has these dice:" + player.CheckDice());
        }

    }
}
