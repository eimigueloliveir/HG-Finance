using Newtonsoft.Json;

namespace HG_Finance.Values
{
    public class Taxes
    {
        public DateFormatHandling date { get; set; }

        public decimal cdi;

        public decimal selic;

        public decimal daily_factor;

        public decimal selic_daily;

        public decimal cdi_daily;
    }
}
