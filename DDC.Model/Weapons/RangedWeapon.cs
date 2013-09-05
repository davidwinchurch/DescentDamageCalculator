using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Weapons
{
    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, DiceCalculator dice, bool isSecondAct = false) : base(name, Type.Ranged, isSecondAct, dice)
        {

        }

        public override double GetHitChance(int range = 0, ReRollType reRollType = ReRollType.None)
        {
            throw new System.NotImplementedException();
        }
    }
}