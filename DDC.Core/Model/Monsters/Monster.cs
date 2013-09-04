using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Monsters
{
    public class Monster
    {
        public Type Type { get; private set; }
        public bool IsMaster { get; private set; }
        public IList<Die> AttackDice { get; private set; }
        public IList<Die> DefenceDice { get; private set; }

        public Monster(Type type, IList<Die> attackDice, IList<Die> defenceDice) : this(type, false, attackDice, defenceDice)
        {
            
        }
            
        protected Monster(Type type, bool isMaster, IList<Die> attackDice, IList<Die> defenceDice)
        {
            Type = type;
            IsMaster = isMaster;
            AttackDice = attackDice;
            DefenceDice = defenceDice;
        }
    }
}