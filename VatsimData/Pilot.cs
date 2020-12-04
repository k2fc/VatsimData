using Newtonsoft.Json;
using System;
using System.Linq;

namespace VatsimData
{
    public class Pilot
    {
        [JsonProperty("pilot_rating")]
        int ratingNum;
        [JsonProperty("server")]
        string server;
        [JsonProperty("cid")]
        public int CID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        public PilotRating Rating
        {
            get
            {
                return VatsimData.Data.PilotRatings.Where(x => x.ID == ratingNum).FirstOrDefault();
            }
            set
            {
                ratingNum = value.ID;
            }
        }
        [JsonProperty("callsign")]
        public string Callsign { get; set; }
        public Server Server
        {
            get
            {
                return VatsimData.Data.Servers.Where(x => x.Ident == server).FirstOrDefault();
            }
            set
            {
                server = value.Ident;
            }
        }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("altitude")]
        public int Altitude { get; set; }
        [JsonProperty("groundspeed")]
        public int Groundspeed { get; set; }
        [JsonProperty("transponder")]
        public string Transponder { get; set; }
        [JsonProperty("heading")]
        public int Heading { get; set; }
        [JsonProperty("qnh_i_hg")]
        public float QnhInHg { get; set; }
        [JsonProperty("qnh_mb")]
        public int QnhMb { get; set; }
        [JsonProperty("flight_plan")]
        public FlightPlan? FlightPlan { get; set; }
        [JsonProperty("logon_time")]
        private string logon_time;
        public DateTime LogonTime { get => DateTime.Parse(logon_time); }
        [JsonProperty("last_updated")]
        private string last_updated;
        public DateTime Last_Updated { get=>DateTime.Parse(last_updated); }
        public override string ToString()
        {
            return Callsign;
        }
        public TimeSpan TimeOnline => DateTime.Now - LogonTime;
    }
}
