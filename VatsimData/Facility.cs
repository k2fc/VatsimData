using Newtonsoft.Json;

namespace VatsimData
{
    public struct Facility
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
}
