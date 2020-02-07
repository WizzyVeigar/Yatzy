using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    class YatzyPlayer : Player, IPlayWithDice<Dice>
    {
        //Make a delegate for our event
        public delegate void YatzyThrowDel(Player player, Dice thrownDice);
        public event YatzyThrowDel yatzyThrow;

        //The players dice
        public List<Dice> playerDice;

        public YatzyPlayer(string name) : base(name)
        {
            //for testing
            //Should be able to choose diceamount from console
            playerDice = GenerateDice(5);
        }

        /// <summary>
        /// Makes a list of dice depending on the <paramref name="amount"/>
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Returns the list of generated dice</returns>
        public List<Dice> GenerateDice(int amount)
        {
            List<Dice> playerDice = new List<Dice>();

            for (int i = 0; i < amount; i++)
            {
                playerDice.Add(new Dice());
            }
            return playerDice;
        }

        /// <summary>
        /// Throws a dice and returns between 0 and SideAmount
        /// </summary>
        /// <param name="diceToThrow"></param>
        /// <returns>returns between 0 and SideAmount</returns>
        public Dice ThrowDice(Dice diceToThrow)
        {
            Random rnd = new Random();
            diceToThrow.DiceValue = (byte)rnd.Next(1, diceToThrow.SideAmount);
            //Call event
            //yatzyThrow(this, diceToThrow);
            return diceToThrow;
        }
        /// <summary>
        /// Checks your dice's current values
        /// </summary>
        /// <returns>Returns your dice's values as a string</returns>
        public string CheckDice()
        {
            string temp = "";
            for (int i = 0; i < playerDice.Count; i++)
            {
                temp += "\nDice number:" + playerDice[i].DiceValue;
            }
            return temp;
        }
    }
}
