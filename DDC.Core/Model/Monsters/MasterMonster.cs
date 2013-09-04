using System.Collections.Generic;
using DDC.Core.Model.Dice;

namespace DDC.Core.Model.Monsters
{
    public class MasterMonster : Monster
    {
        public MasterMonster(Type type, IList<Die> attackDice, IList<Die> defenceDice) : base(type, true, attackDice, defenceDice)
        {

        }
    }
}