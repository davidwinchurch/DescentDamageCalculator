using System.Collections.Generic;
using System.Linq;

namespace DDC.Core.Model.Die
{
    public enum Symbol
    {
        Miss,
        Heart,
        Surge,
        Range,
        Shield
    }

    public enum Type
    {
        BlueAttack,
        YellowAttack,
        RedAttack,
        GreenAttack,
        BrownDefence,
        GreyDefence,
        BlackDefence,
    }

    public class Die
    {
        public static readonly Die BlueAttackDie = new Die(Type.BlueAttack, new[]
            {
                Face.GetMissFace(),

            });

        public Type Type { get; private set; }
        public IList<Face> Faces { get; private set; }

        private Die(Type type, IList<Face> faces)
        {
            Type = type;
            Faces = faces;
        }
    }

    public class Face
    {
        public bool IsMiss
        {
            get { return SymbolQuantities.Any(sq => sq.Symbol == Symbol.Miss); }
        }

        public int Hearts
        {
            get { return GetSymbolCount(Symbol.Heart); }
        }

        public int Surges
        {
            get { return GetSymbolCount(Symbol.Surge); }
        }

        public int Range
        {
            get { return GetSymbolCount(Symbol.Range); }
        }

        public int Shields
        {
            get { return GetSymbolCount(Symbol.Shield); }
        }

        public static Face GetMissFace()
        {
            return new Face(new List<SymbolCount> { new SymbolCount(Symbol.Miss, 1) });
        }

        public static Face GetAttackFace(int heartCount, int surgeCount, int range)
        {
            return new Face(new List<SymbolCount>
                {
                    new SymbolCount(Symbol.Heart, heartCount),
                    new SymbolCount(Symbol.Surge, heartCount),
                    new SymbolCount(Symbol.Range, range)
                });
        }

        public static Face GetDefenseFace(int count)
        {
            return new Face(new List<SymbolCount> { new SymbolCount(Symbol.Shield, count) });
        }
        
        private Face(IList<SymbolCount> symbolQuantities)
        {
            SymbolQuantities = symbolQuantities;
        }

        private IList<SymbolCount> SymbolQuantities { get; set; }

        private int GetSymbolCount(Symbol symbol)
        {
            var symbolCount = SymbolQuantities.FirstOrDefault(sq => sq.Symbol == symbol);
            return symbolCount == null ? 0 : symbolCount.Count;
        }

        private class SymbolCount
        {
            public SymbolCount(Symbol symbol, int count)
            {
                Symbol = symbol;
                Count = count;
            }

            public Symbol Symbol { get; private set; }
            public int Count { get; private set; }
        }
    }
}