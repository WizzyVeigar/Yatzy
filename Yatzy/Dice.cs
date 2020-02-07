using System.Collections.Generic;

namespace Yatzy
{
    internal class Dice
    {
        //Each player will throw these
        private byte diceValue;
        /// <summary>
        /// Contains the dice's current value
        /// </summary>
        public byte DiceValue
        {
            get { return diceValue; }
            set { diceValue = value; }
        }

        private byte sideAmount = 6;
        /// <summary>
        /// Amount of sides on the dice; d6, d12..
        /// </summary>
        public byte SideAmount 
        {
            get { return sideAmount; }
            set { sideAmount = value; }
        }

    }
}