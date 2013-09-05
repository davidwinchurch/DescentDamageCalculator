using DDC.Model.Dice;

namespace DDC.Model.Monsters
{
    public static class MonsterFactory
    {
        public static readonly Monster Zombie = new Monster(Type.Zombie, DieFactory.AttackBlueRed, DieFactory.DefenceBrown);
    }
}