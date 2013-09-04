using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; private set; }
        public Type Type { get; private set; }
        public bool IsSecondAct { get; private set; }
        public IList<Die> Dice { get; private set; }

        public abstract double GetHitChance(int range = 0, ReRollType reRollType = ReRollType.None);

        protected Weapon(string name, Type type, bool isSecondAct, IList<Die> dice)
        {
            Name = name;
            Type = type;
            IsSecondAct = isSecondAct;
            Dice = dice;
        }
    }
}