using System;

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

            gameManager.GeneratePlayers(yatzyGame.PlayerAmount);
            yatzyGame.Play(yatzyGame.PlayerAmount);
        }
    }
}
