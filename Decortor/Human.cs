using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decortor
{
    class Human
    {
        public Human() :MainCharacter
        {
            Name = "Human";
            Attack = 20;
            Speed = 20;
            Health = 150;
            Armor = 0;
        }
    }
}
