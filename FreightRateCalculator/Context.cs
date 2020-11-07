using FreightRateCalculator.Calculators.Interfaces;
using FreightRateCalculator.Models;

namespace FreightRateCalculator
{
    public sealed class Context
    {
        private IFreightCalculatorStrategy _freightCalculatorStrategy;     

        public void SetStrategy(IFreightCalculatorStrategy freightCalculatorStrategy)
        {
            _freightCalculatorStrategy = freightCalculatorStrategy;
        }

        public decimal GetEstimatedQuotes(FreightData freightData)
        {
            return _freightCalculatorStrategy.Calculate(freightData);
        }
    }
}
