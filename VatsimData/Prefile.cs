using Newtonsoft.Json;
using System;

namespace VatsimData
{
    public class Prefile
    {
        [JsonProperty("cid")]
        public string CID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("callsign")]
        public string Callsign { get; set; }
        [JsonProperty("flight_plan")]
        public FlightPlan? FlightPlan { get; set; }
        [JsonProperty("last_updated")]
        private string last_updated;
        public DateTime Last_Updated { get => DateTime.Parse(last_updated); }
        public override string ToString()
        {
            return Callsign;
        }
    }
}
