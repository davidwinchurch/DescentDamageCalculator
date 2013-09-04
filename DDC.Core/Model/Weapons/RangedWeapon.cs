using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Weapons
{
    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, IList<Die> dice) : base(name, Type.Ranged, dice)
        {

        }

        public override double GetHitChance(int range = 0)
        {
            throw new System.NotImplementedException();
        }
    }
}