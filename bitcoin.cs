using Newtonsoft.Json;

namespace HG_Finance
{
    public class bitcoin
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "last")]
        public decimal last { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal buy { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal sell { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal variation { get; set; }
    }
}
