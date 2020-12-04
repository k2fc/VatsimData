using Newtonsoft.Json;

namespace VatsimData
{
    public struct Server
    {
        [JsonProperty("ident")]
        public string Ident { get; set; }
        [JsonProperty("hostname_or_ip")]
        public string Hostname { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("clients_connection_allowed")]
        public int ClientsAllowed { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
