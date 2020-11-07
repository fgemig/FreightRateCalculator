using FreightRateCalculator.Calculators.Interfaces;
using FreightRateCalculator.Models;

namespace FreightRateCalculator.Calculators
{
    public class AirFreight : IFreightCalculatorStrategy
    {
        public decimal Calculate(FreightData freightData)
        {
            return freightData.MaximumPayload * 0.5M;
        }
    }
}
