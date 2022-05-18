using HG_Finance.Values;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace HG_Finance
{
    public class HG_Client
    {
        public string Key = "";
        public string Symbol = "";
        
        public Bitcoin BitcoinResponse = new();
        public Currency CurrencyResponse = new();
        public Stocks StocksResponse = new();
        public Taxes TaxesResponse = new();

        public void Currencies(string currency)
        {
            if (Key == "")
            {
                throw new Exception("Key must be different from null");
            }
            else if (currency == "")
            {
                throw new Exception("currency must be different from null");
            }
            else
            {
                HttpClient client = new();
                string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{currency}&key={Key}";
                try
                {
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    string result = response.Content.ReadAsStringAsync().Result;
                    D_Market market = JsonConvert.DeserializeObject<D_Market>(result);
                    CurrencyResponse.Name = market.Currency.Name;
                    CurrencyResponse.Buy = market.Currency.Buy;
                    CurrencyResponse.Sell = market.Currency.Sell;
                    CurrencyResponse.Variation = market.Currency.Variation;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void Stocks()
        {
            if (Key == "")
            {
                throw new Exception("Key must be different from null");
            }
            else if (Symbol == "")
            {
                throw new Exception("currency must be different from null");
            }
            else
            {
                HttpClient client = new();
                string URL = $"https://api.hgbrasil.com/finance/stock_price?key={Key}&symbol={Symbol}";
                try
                {
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    string result = response.Content.ReadAsStringAsync().Result;
                    D_Market market = JsonConvert.DeserializeObject<D_Market>(result);
                    StocksResponse.Name = market.Stocks.Name;
                    StocksResponse.points = market.Stocks.points;
                    StocksResponse.location = market.Stocks.location;
                    StocksResponse.variation = market.Stocks.variation;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void Bitcoin(string corretora)
        {
            if (Key == "")
            {
                throw new Exception("Key must be different from null");
            }
            else if (corretora == "")
            {
                throw new Exception("currency must be different from null");
            }
            else
            {
                HttpClient client = new();
                string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={Key}";
                try
                {
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    string result = response.Content.ReadAsStringAsync().Result;
                    D_Market market = JsonConvert.DeserializeObject<D_Market>(result);
                    BitcoinResponse.last = market.Bitcoin.last;
                    BitcoinResponse.variation = market.Bitcoin.variation;
                    BitcoinResponse.Name = market.Bitcoin.Name;
                    BitcoinResponse.buy = market.Bitcoin.buy;
                    BitcoinResponse.sell = market.Bitcoin.sell;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void Taxes()
        {
            if (Key == "")
            {
                throw new Exception("Key must be different from null");
            }
            else
            {
                HttpClient client = new();
                string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,&key={Key}";
                try
                {
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    string result = response.Content.ReadAsStringAsync().Result;
                    D_Market market = JsonConvert.DeserializeObject<D_Market>(result);
                    TaxesResponse.daily_factor = market.Taxes.daily_factor;
                    TaxesResponse.cdi = market.Taxes.cdi;
                    TaxesResponse.cdi_daily = market.Taxes.cdi_daily;
                    TaxesResponse.selic = market.Taxes.selic;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}