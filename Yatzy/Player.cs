using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
     abstract class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
