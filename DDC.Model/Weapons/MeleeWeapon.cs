using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Weapons
{
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, DiceCalculator dice, bool isSecondAct = false) : base(name, Type.Melee, isSecondAct, dice)
        {

        }

        public override double GetHitChance(int range = 0, ReRollType reRollType = ReRollType.None)
        {
            throw new System.NotImplementedException();
        }
    }
}