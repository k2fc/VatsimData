using Newtonsoft.Json;
using System;
using System.Linq;

namespace VatsimData
{
    public class Atis
    {
        [JsonProperty("facility")]
        int facilityNum;
        [JsonProperty("rating")]
        int ratingNum;
        [JsonProperty("server")]
        string server;
        [JsonProperty("cid")]
        public int CID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("callsign")]
        public string Callsign { get; set; }
        [JsonProperty("frequency")]
        public string Frequency { get; set; }
        [JsonProperty("visual_range")]
        public int VisualRange { get; set; }
        [JsonProperty("atis_code")]
        public string AtisCode { get; set; }
        [JsonProperty("text_atis")]
        public string[] TextAtis { get; set; }
        [JsonProperty("logon_time")]
        private string logon_time;
        public DateTime LogonTime { get => DateTime.Parse(logon_time); }
        [JsonProperty("last_updated")]
        private string last_updated;
        public DateTime Last_Updated { get => DateTime.Parse(last_updated); }

        public Facility Facility
        {
            get
            {
                return VatsimData.Data.Facilities.Where(x => x.ID == facilityNum).FirstOrDefault();
            }
            set
            {
                facilityNum = value.ID;
            }
        }

        public Rating Rating
        {
            get
            {
                return VatsimData.Data.Ratings.Where(x => x.ID == ratingNum).FirstOrDefault();
            }
            set
            {
                ratingNum = value.ID;
            }
        }

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
        public override string ToString()
        {
            return Callsign;
        }
        public TimeSpan TimeOnline => DateTime.Now - LogonTime;
    }
}
