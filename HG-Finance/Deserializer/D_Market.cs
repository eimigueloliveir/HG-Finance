using Newtonsoft.Json;

namespace HG_Finance
{
    public class D_Market
    {
        public D_Market()
        {
            this.Currency = new D_Currency();
            this.Stocks = new D_Stocks();
            this.Bitcoin = new D_Bitcoin();
            this.Taxes = new D_Taxes();
        }

        [JsonProperty(PropertyName = "currencies")]
        public D_Currency Currency { get; set; }

        [JsonProperty(PropertyName = "stocks")]
        public D_Stocks Stocks { get; set; }

        [JsonProperty(PropertyName = "bitcoin")]
        public D_Bitcoin Bitcoin { get; set; }

        [JsonProperty(PropertyName = "taxes")]
        public D_Taxes Taxes { get; set; }
    }
}
