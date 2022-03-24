using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace HG_Finance
{
    public class HG_Client
    {
        public static string key = "";
        public static string symbol = "";
        
        #region correncies
        public static string currenciesName(string currency)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{currency}&key={key}";
            string name = "";
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                name = market.Currency.Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return name;
        }
        public static decimal currenciesBuy(string currency)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{currency}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.Currency.Buy;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return value;
        }
        public static decimal currenciesSell(string currency)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{currency}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.Currency.Sell;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return value;
        }
        public static decimal currenciesVariation(string currency)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{currency}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.Currency.Variation;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return value;
        }
        #endregion
        
        public static string stocksName()
        {

            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance/stock_price?key={key}&symbol={symbol}";
            string name = "";
            try
            {
                var response =  client.GetAsync(URL).Result;
                var result =  response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                name = market.stocks.Name;
                Console.WriteLine(result);
                Console.WriteLine(market.bitcoin.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return name;
        }
        public static string stocksLocation(string stocksName)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{stocksName}&key={key}";
            string name = "";
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                name = market.stocks.location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return name;
        }
        public static decimal stocksPoints(string stocksName)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{stocksName}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.stocks.points;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static decimal stocksVariention(string stocksName)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{stocksName}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.stocks.variation;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static string bitcoinPoints(string corretora)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={key}";
            string value = "";
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.bitcoin.Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static decimal bitcoinLast(string corretora)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.bitcoin.last;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static decimal bitcoinBuy(string corretora)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.bitcoin.buy;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static decimal bitcoinSell(string corretora)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.bitcoin.sell;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static decimal bitcoinVariation(string corretora)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,{corretora}&key={key}";
            decimal value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.bitcoin.variation;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public static DateFormatHandling taxesData()
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,&key={key}";
            DateFormatHandling value = 0;
            try
            {
                var response = client.GetAsync(URL).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Market market = JsonConvert.DeserializeObject<Market>(result);
                value = market.taxes.date;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }

    }
}
