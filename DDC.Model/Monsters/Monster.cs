using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Monsters
{
    public class Monster
    {
        public Type Type { get; private set; }
        public bool IsMaster { get; private set; }
        public bool IsSecondAct { get; private set; }
        public DiceCalculator AttackDice { get; private set; }
        public DiceCalculator DefenceDice { get; private set; }

        public Monster(Type type, DiceCalculator attackDice, DiceCalculator defenceDice, bool isSecondAct = false) : this(type, false, isSecondAct, attackDice, defenceDice)
        {
            
        }
            
        protected Monster(Type type, bool isMaster, bool isSecondAct, DiceCalculator attackDice, DiceCalculator defenceDice)
        {
            Type = type;
            IsMaster = isMaster;
            IsSecondAct = isSecondAct;
            AttackDice = attackDice;
            DefenceDice = defenceDice;
        }
    }
}