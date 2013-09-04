using System.Collections.Generic;
using DDC.Model.Dice;

namespace DDC.Model.Monsters
{
    public class MasterMonster : Monster
    {
        public MasterMonster(Type type, IList<Die> attackDice, IList<Die> defenceDice, bool isSecondAct = false) : base(type, true, isSecondAct, attackDice, defenceDice)
        {

        }
    }
}