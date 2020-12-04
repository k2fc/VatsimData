using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace VatsimData
{
    public class VatsimData
    {
        [JsonProperty("general")]
        public General General;

        [JsonProperty("pilots")]
        public Pilot[] Pilots;

        [JsonProperty("controllers")]
        public Controller[] Controllers;

        [JsonProperty("atis")]
        public Atis[] Atis;

        [JsonProperty("servers")]
        public Server[] Servers;

        [JsonProperty("prefiles")]
        public Prefile[] Prefiles;

        [JsonProperty("facilities")]
        public Facility[] Facilities;

        [JsonProperty("ratings")]
        public Rating[] Ratings;

        [JsonProperty("pilot_ratings")]
        public PilotRating[] PilotRatings;

        public static VatsimData Data = new VatsimData();

        public static void GetData(string url)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.ContentType = "application/json";
            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var jsonData = sr.ReadToEnd();
                    Data = JsonConvert.DeserializeObject<VatsimData>(jsonData);
                }
            }
        }
    }

    public struct General
    {
        [JsonProperty("version")] 
        public int Version { get; set; }
        [JsonProperty("reload")]
        public int Reload { get; set; }
        [JsonProperty("update")]
        public string Update { get; set; }
        [JsonProperty("update_timestamp")]
        private string update_timestamp;
        public DateTime UpdateTimestamp { get=> DateTime.Parse(update_timestamp); }
        [JsonProperty("connected_clients")]
        public int ConnectedClients { get; set; }
        [JsonProperty("unique_users")]
        public int UniqueUsers { get; set; }
    }
}
