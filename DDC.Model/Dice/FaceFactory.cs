using System.Collections.Generic;

namespace DDC.Model.Dice
{
    internal class FaceFactory
    {
        public static Face GetMissFace()
        {
            return new Face(new List<SymbolCount> { new SymbolCount(Symbol.Miss, 1) });
        }

        public static Face GetAttackFace(int range, int heartCount, int surgeCount)
        {
            return new Face(new List<SymbolCount>
                {
                    new SymbolCount(Symbol.Range, range),
                    new SymbolCount(Symbol.Heart, heartCount),
                    new SymbolCount(Symbol.Surge, surgeCount)
                });
        }

        public static Face GetDefenceFace(int count)
        {
            return new Face(new List<SymbolCount> { new SymbolCount(Symbol.Shield, count) });
        }
    }
}