using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Weapons
{
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, IList<Die> dice) : base(name, Type.Melee, dice)
        {

        }

        public override double GetHitChance(int range = 0, ReRollType reRollType = ReRollType.None)
        {
            throw new System.NotImplementedException();
        }
    }
}