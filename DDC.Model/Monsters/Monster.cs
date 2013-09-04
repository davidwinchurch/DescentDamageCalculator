using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Monsters
{
    public class Monster
    {
        public Type Type { get; private set; }
        public bool IsMaster { get; private set; }
        public bool IsSecondAct { get; private set; }
        public IList<Die> AttackDice { get; private set; }
        public IList<Die> DefenceDice { get; private set; }

        public Monster(Type type, IList<Die> attackDice, IList<Die> defenceDice, bool isSecondAct = false) : this(type, false, isSecondAct, attackDice, defenceDice)
        {
            
        }
            
        protected Monster(Type type, bool isMaster, bool isSecondAct, IList<Die> attackDice, IList<Die> defenceDice)
        {
            Type = type;
            IsMaster = isMaster;
            IsSecondAct = isSecondAct;
            AttackDice = attackDice;
            DefenceDice = defenceDice;
        }
    }
}