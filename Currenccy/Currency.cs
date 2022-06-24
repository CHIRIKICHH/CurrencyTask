namespace CurrencyTask
{
    internal abstract class Currency
    {
        internal double ExchangeRate
        {
            get => GetRate();
        }

        internal abstract double GetRate();
    }
}
