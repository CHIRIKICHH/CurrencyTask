using System;

namespace CurrencyTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mdl = new MDL();
            var rub = new RUB();
            var uah = new UAH();

            var mdlToRub = CurrencyConverter.Convert(mdl, rub, 100);
            var rubToUah = CurrencyConverter.Convert(rub, uah, 300);

            Console.WriteLine($"100 лей в рублях = {mdlToRub}");
            Console.WriteLine($"300 рублей в гривнах = {rubToUah}");

        }
    }
}
