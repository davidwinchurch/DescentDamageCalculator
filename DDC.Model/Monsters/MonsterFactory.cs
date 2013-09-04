using DDC.Model.Dice;

namespace DDC.Model.Monsters
{
    public static class MonsterFactory
    {
        public static readonly Monster Zombie = new Monster(Type.Zombie, DieFactory.CreateDice(Dice.Type.BlueAttack, Dice.Type.RedAttack), DieFactory.CreateDice(Dice.Type.BrownDefence));
    }
}