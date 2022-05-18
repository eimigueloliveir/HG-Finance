using Newtonsoft.Json;

namespace HG_Finance
{
    public class D_Stocks
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string location { get; set; }

        [JsonProperty(PropertyName = "points")]
        public decimal points { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal variation { get; set; }
    }
}
