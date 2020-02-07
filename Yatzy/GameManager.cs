using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    class GameManager
    {
        //Make this use player instead of YatzyPlayer
        public List<YatzyPlayer> currentPlayers = new List<YatzyPlayer>();

        //holds scores over players playing
        public void GeneratePlayers(byte amount)
        {
            for (int i = 0; i < amount; i++)
            {
                //add and create a player to playerList
                //Should new be new yatzyPlayer, but im limiting myself
                currentPlayers.Add(new YatzyPlayer("Player" + i));
            }
        }

    }
}
