using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    abstract class Game
    {
        private byte playerAmount;

        protected Game(byte playerAmount)
        {
            PlayerAmount = playerAmount;
        }

        public byte PlayerAmount
        {
            get { return playerAmount; }
            set { playerAmount = value; }
        }

    }
}
