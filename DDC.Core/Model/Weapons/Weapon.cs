using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; private set; }
        public Type Type { get; private set; }
        public IList<Die> Dice { get; private set; }

        public abstract double GetHitChance(int range = 0, ReRollType reRollType = ReRollType.None);

        protected Weapon(string name, Type type, IList<Die> dice)
        {
            Name = name;
            Type = type;
            Dice = dice;
        }
    }
}