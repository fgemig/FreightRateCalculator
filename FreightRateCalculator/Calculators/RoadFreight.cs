using FreightRateCalculator.Calculators.Interfaces;
using FreightRateCalculator.Models;
using System;

namespace FreightRateCalculator.Calculators
{
    public class RoadFreight : IFreightCalculatorStrategy
    {
        public decimal Calculate(FreightData freightData)
        {
            if (freightData.IsInternationalFreight())
                throw new InvalidOperationException("International shipment. See other options more suitable to your business");

            return freightData.MaximumPayload * 0.03M;
        }
    }
}
