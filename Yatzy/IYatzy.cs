using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    interface IYatzy<T>
    {
        bool checkForYatzy(List<T> obj);
    }
}
