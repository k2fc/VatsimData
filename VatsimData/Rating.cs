using Newtonsoft.Json;

namespace VatsimData
{
    public struct Rating
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("short")]
        public string Short { get; set; }
        [JsonProperty("long")]
        public string Long { get; set; }
        public override string ToString()
        {
            return Short;
        }
    }

    public struct PilotRating
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("short_name")]
        public string Short { get; set; }
        [JsonProperty("long_name")]
        public string Long { get; set; }
        public override string ToString()
        {
            return Short;
        }
    }
}
