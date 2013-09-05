using System.Collections.Generic;

namespace DDC.Model.Dice
{
    public class DiceCalculator
    {
        public IList<Die> Dice { get; private set; }

        public int GetHitProbability(int range)
        {
            return 0;
        }

        internal DiceCalculator(params Die[] dice)
        {
            Dice = dice;
        }
        
        internal DiceCalculator(IList<Die> dice)
        {
            Dice = dice;
        }
    }
}