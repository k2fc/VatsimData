using Newtonsoft.Json;

namespace VatsimData
{
    public struct FlightPlan
    {
        [JsonProperty("flight_rules")]
        public string FlightRules { get; set; }
        [JsonProperty("aircraft")]
        public string Aircraft { get; set; }
        [JsonProperty("departure")]
        public string Departure { get; set; }
        [JsonProperty("arrival")]
        public string Arrival { get; set; }
        [JsonProperty("alternate")]
        public string Alternate { get; set; }
        [JsonProperty("cruise_tas")]
        public string CruiseTAS { get; set; }
        [JsonProperty("altitude")]
        public string Altitude { get; set; }
        [JsonProperty("deptime")]
        public string DepartureTime { get; set; }
        [JsonProperty("enroute_time")]
        public string EnrouteTime { get; set; }
        [JsonProperty("fuel_time")]
        public string FuelTime { get; set; }
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
        [JsonProperty("route")]
        public string Route { get; set; }
        public override string ToString()
        {
            return string.Format("{0}-{1} ({2}FR)", Departure, Arrival, FlightRules);
        }
    }
}
