namespace FreightRateCalculator.Models
{
    public class FreightData
    {
        public FreightData(Location origin, Location destination, decimal maximumPayload)
        {
            Origin = origin;
            Destination = destination;
            MaximumPayload = maximumPayload;
        }

        public Location Origin { get; private set; }

        public Location Destination { get; private set; }

        public decimal MaximumPayload { get; private set; }

        public bool IsInternationalFreight()
            => Origin.Country != Destination.Country;
    }
}
