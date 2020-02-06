using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    interface IPlayWithDice<T>
    {
        List<T> GenerateDice(int amount);
        T ThrowDice(T diceToThrow);
    }
}
