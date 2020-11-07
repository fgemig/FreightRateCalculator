using FreightRateCalculator.Models;

namespace FreightRateCalculator.Calculators.Interfaces
{
    public interface IFreightCalculatorStrategy
    {
        public decimal Calculate(FreightData freightData);
    }
}