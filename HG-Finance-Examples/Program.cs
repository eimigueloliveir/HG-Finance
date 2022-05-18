using HG_Finance;
using System;

namespace HG_Finance_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HG_Client client = new()
                {
                    Key = "Key"
                };
                client.Currencies("USD");
                Console.WriteLine(client.CurrencyResponse.Buy);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
