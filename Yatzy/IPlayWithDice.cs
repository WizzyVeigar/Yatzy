using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    interface IPlayWithDice<T>
    {
        //I'm not sure if the player should generate the dice
        List<T> GenerateDice(int amount);

        T ThrowDice(T diceToThrow);
    }
}
