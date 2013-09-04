using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Weapons
{
    public class Weapon
    {
        public Type Type { get; private set; }
        public IList<Die> Dice { get; private set; }
    }
}