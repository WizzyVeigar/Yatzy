using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{   //Implement rules as interfaces
    class YatzyGame : Game, I1Pair<Dice>
    {
        public YatzyGame(byte playerAmount) : base(playerAmount)
        {
        }


        //Make more dynamic
        internal void Play(byte playerAmount)
        {
            throw new NotImplementedException();
        }


        //Rules section

        public bool CheckForPair(List<Dice> obj)
        {
            throw new NotImplementedException();
        }
    }
}
