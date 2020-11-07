using FreightRateCalculator.Calculators;
using FreightRateCalculator.Models;
using FreightRateCalculator.Types;
using System;

namespace FreightRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {           
            Options options = Options.Road;

            var context = new Context();

            context.SetStrategy(options switch
            {
                Options.Air => new AirFreight(),
                Options.Road => new RoadFreight(),
                Options.Sea => new SeaFreight(),
                _ => throw new ArgumentException("Invalid option")
            });           

            var costs = context.GetEstimatedQuotes(GetFreightData());

            Console.WriteLine($"GetEstimatedQuotes: {costs:c2}");
        }

        public static FreightData GetFreightData()
        {
            var origin = new Location("000001", "São Paulo", "Brazil");
            var destination = new Location("000025", "Amapá", "Brazil");

            return new FreightData(origin, destination, maximumPayload: 100_000);
        }
    }
}
