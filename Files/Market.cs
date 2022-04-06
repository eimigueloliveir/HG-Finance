
using Newtonsoft.Json;

namespace HG_Finance
{
    public class Market
    {
        public Market()
        {
            this.Currency = new Currency();
            this.stocks = new stocks();
            this.bitcoin = new bitcoin();
            this.taxes = new taxes();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }

        [JsonProperty(PropertyName = "stocks")]
        public stocks stocks { get; set; }

        [JsonProperty(PropertyName = "bitcoin")]
        public bitcoin bitcoin { get; set; }

        [JsonProperty(PropertyName = "taxes")]
        public taxes taxes { get; set; }


    }
}
