using System.Collections.Generic;
using System.Linq;

namespace DDC.Model.Dice
{
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

        internal Face(IList<SymbolCount> symbolQuantities)
        {
            SymbolQuantities = symbolQuantities;
        }

        private IList<SymbolCount> SymbolQuantities { get; set; }

        private int GetSymbolCount(Symbol symbol)
        {
            var symbolCount = SymbolQuantities.FirstOrDefault(sq => sq.Symbol == symbol);
            return symbolCount == null ? 0 : symbolCount.Count;
        }    
    }
}