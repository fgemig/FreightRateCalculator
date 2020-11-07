namespace FreightRateCalculator.Models
{
    public struct Location
    {
        public Location(string zipCode, string state, string country)
        {
            ZipCode = zipCode;
            State = state;
            Country = country;
        }

        public string ZipCode { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }
    }
}
