using DDC.Model.Dice;

namespace DDC.Model.Weapons
{
    public class WeaponFactory
    {
        public static readonly Weapon IronLongsword = new MeleeWeapon("Iron Longsword", DieFactory.AttackBlueRed);
    }
}