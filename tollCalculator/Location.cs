using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace tollCalculator
{
	class Location
	{
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("routes")]
        public List<Route> Routes { get; set; }

        [JsonProperty("devcomment", NullValueHandling = NullValueHandling.Ignore)]
        public string Devcomment { get; set; }
    }
}
