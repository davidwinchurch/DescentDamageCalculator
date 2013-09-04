namespace DDC.Model.Dice
{
    internal class SymbolCount
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