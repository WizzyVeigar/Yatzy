using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{   //Implement rules as interfaces
    class YatzyGame : DiceGame, I1Pair<Dice>
    {
        public delegate void ShowPlayerDice(YatzyPlayer player);
        public delegate List<Dice> LockPlayerDice(YatzyPlayer player);
        public event ShowPlayerDice checkDiceEvent;
        public event LockPlayerDice LockPlayerDiceEvent;
        

        public YatzyGame(byte playerAmount) : base(playerAmount)
        {
        }

        //Make more dynamic
        internal void Play(List<YatzyPlayer> players)
        {
            foreach (YatzyPlayer player in players)
            {
                List<Dice> keptDice = new List<Dice>();
                //This loop works as all 3 throws
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < player.playerDice.Count; j++)
                    {
                        player.playerDice[j] = player.ThrowDice(player.playerDice[j]);
                    }
                    //Call check dice event
                    checkDiceEvent(player);
                    keptDice = LockPlayerDiceEvent(player);
                    Console.ReadKey();
                    //Keep any dice?

                    //Stop?
                    //if(input == yes)
                    //  Break;
                }
                //Result
                //Show all applicable columns
                //Check for taken columns
                //allocate points in available columns
            }
        }


        //Rules section

        public bool CheckForPair(List<Dice> obj)
        {
            throw new NotImplementedException();
        }
    }
}
