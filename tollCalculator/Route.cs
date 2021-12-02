using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace tollCalculator
{
	class Route
	{
        [JsonProperty("toId")]
        public long ToId { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("exit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exit { get; set; }

        [JsonProperty("enter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enter { get; set; }

        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }
    }
}
