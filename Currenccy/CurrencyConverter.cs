using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTask
{
    internal class CurrencyConverter
    {
        public static double Convert(Currency inCurrency, Currency outCurrency, double quantity)
        {
            return quantity / inCurrency.ExchangeRate * outCurrency.ExchangeRate;
        }
    }
}
