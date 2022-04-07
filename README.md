# HG Finance

Welcome to the HG Finance library for CSharp!

Now you can simply get financial data (currency exchange, cryptocurrency exchange, Brazilian government taxes and stock market) from the HG Finance API directly in your Csharp app!

Some features are under development 😊

## Available data

### Cryptocurrencies exchange

- Blockchain.info
    - BTC to USD Dollar
- Coinbase
    - BTC to USD Dollar
- BitStamp
    - BTC to USD Dollar
- FoxBit
    - BTC to BRL Brazilian Real
- Mercado Bitcoin
    - BTC to BRL Brazilian Real
- OmniTrade
    - BTC to BRL Brazilian Real  

### Stock markets

- BM&F BOVESPA Sao Paulo, Brazil
- NASDAQ New York City, United States
- CAC 40 Paris, French
- Nikkei 225 Tokyo, Japan

### Currencies exchange

- USD Dollar to BRL Brazilian Real
- EUR Euro to BRL Brazilian Real
- GBP Pound Sterling to BRL Brazilian Real
- ARS Argentine Peso to BRL Brazilian Real
- BTC Bitcoin (blockchain.info) to BRL Brazilian Real

### Taxes

- Brazilian CDI
- Brazilian Selic

## Install

- 📦 [NuGet](https://www.nuget.org/packages/HG-Finance/): `dotnet add package HG-Finance --version 1.0.0` (**package**)


### Usage

- first add the library import
```csharp
using HG_Finance;
```
- first create a variable and add your Key
```csharp
HG_Client.key = "your key";
```
**using CurrenciesBuy**

- the quotation of several currencies against the real such as Dollar (USD), Euro (EUR), Pound (GBP), Peso (ARS), Canadian Dollar (CAD), Australian Dollar (AUD), Japanese Yen (JPY), China Renminbi (CNY) and Bitcoin (BTC);

```csharp
decimal correncies = HG_Client.currenciesBuy("desired currency");
```



## License

The gem is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).
