using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    class YatzyPlayer : Player, IPlayWithDice<Dice>
    {
        public YatzyPlayer(string name) : base(name)
        {
        }

        public List<Dice> GenerateDice(int amount)
        {
            List<Dice> playerDice = new List<Dice>();

            for (int i = 0; i < amount; i++)
            {
                playerDice.Add(new Dice());
            }
            return playerDice;
        }

        public Dice ThrowDice(Dice diceToThrow)
        {
            Random rnd = new Random();

            diceToThrow.DiceValue = rnd.Next(0, diceToThrow.SideAmount);

            return diceToThrow;
        }
    }
}
