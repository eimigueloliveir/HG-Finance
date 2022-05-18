using Newtonsoft.Json;

namespace HG_Finance
{
    public class D_Taxes
    {
        [JsonProperty(PropertyName = "date")]
        public DateFormatHandling date { get; set; }

        [JsonProperty(PropertyName = "cdi")]
        public decimal cdi { get; set; }

        [JsonProperty(PropertyName = "selic")]
        public decimal selic { get; set; }

        [JsonProperty(PropertyName = "daily_factor")]
        public decimal daily_factor { get; set; }

        [JsonProperty(PropertyName = "selic_daily")]
        public decimal selic_daily { get; set; }

        [JsonProperty(PropertyName = "cdi_daily")]
        public decimal cdi_daily { get; set; }
    }
}
