# ![Coinbase.Net](https://raw.githubusercontent.com/JKorf/Coinbase.Net/master/Coinbase.Net/Icon/icon.png) Coinbase.Net  

[![.NET](https://img.shields.io/github/actions/workflow/status/JKorf/Coinbase.Net/dotnet.yml?style=for-the-badge)](https://github.com/JKorf/Coinbase.Net/actions/workflows/dotnet.yml) ![License](https://img.shields.io/github/license/JKorf/Coinbase.Net?style=for-the-badge)

Coinbase.Net is a client library for accessing the [Coinbase Advanced Trade REST and Websocket API](https://docs.cdp.coinbase.com/advanced-trade/docs/welcome) and [Coinbase App REST API](https://docs.cdp.coinbase.com/coinbase-app/docs/welcome). 

## Features
* Response data is mapped to descriptive models
* Input parameters and response values are mapped to discriptive enum values where possible
* Automatic websocket (re)connection management 
* Client side rate limiting 
* Cient side order book implementation
* Extensive logging
* Support for different environments
* Easy integration with other exchange client based on the CryptoExchange.Net base library

## Supported Frameworks
The library is targeting both `.NET Standard 2.0` and `.NET Standard 2.1` for optimal compatibility

|.NET implementation|Version Support|
|--|--|
|.NET Core|`2.0` and higher|
|.NET Framework|`4.6.1` and higher|
|Mono|`5.4` and higher|
|Xamarin.iOS|`10.14` and higher|
|Xamarin.Android|`8.0` and higher|
|UWP|`10.0.16299` and higher|
|Unity|`2018.1` and higher|

## Install the library

### NuGet 
[![NuGet version](https://img.shields.io/nuget/v/Jkorf.Coinbase.net.svg?style=for-the-badge)](https://www.nuget.org/packages/Jkorf.Coinbase.Net)  [![Nuget downloads](https://img.shields.io/nuget/dt/Jkorf.Coinbase.Net.svg?style=for-the-badge)](https://www.nuget.org/packages/Jkorf.Coinbase.Net)

	dotnet add package Coinbase.Net
	
### GitHub packages
Coinbase.Net is available on [GitHub packages](https://github.com/JKorf/Coinbase.Net/pkgs/nuget/Jkorf.Coinbase.Net). You'll need to add `https://nuget.pkg.github.com/JKorf/index.json` as a NuGet package source.

### Download release
[![GitHub Release](https://img.shields.io/github/v/release/JKorf/Coinbase.Net?style=for-the-badge&label=GitHub)](https://github.com/JKorf/Coinbase.Net/releases)

The NuGet package files are added along side the source with the latest GitHub release which can found [here](https://github.com/JKorf/Coinbase.Net/releases).

## How to use
* REST Endpoints
	```csharp
	// Get the ETH/USDT ticker via rest request
	var restClient = new CoinbaseRestClient();
	var tickerResult = await restClient.AdvancedTradeApi.ExchangeData.GetSymbolAsync("ETH-USDT");
	var lastPrice = tickerResult.Data.LastPrice;
	```
* Websocket streams
	```csharp
	// Subscribe to ETH/USDT ticker updates via the websocket API
	var socketClient = new CoinbaseSocketClient();
	var tickerSubscriptionResult = socketClient.AdvancedTradeApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) => 
	{
	  var lastPrice = update.Data.LastPrice;
	});
	```

For information on the clients, dependency injection, response processing and more see the [documentation](https://jkorf.github.io/CryptoExchange.Net), or have a look at the examples [here](https://github.com/JKorf/Coinbase.Net/tree/main/Examples) or [here](https://github.com/JKorf/CryptoExchange.Net/tree/master/Examples).

## CryptoExchange.Net
Coinbase.Net is based on the [CryptoExchange.Net](https://github.com/JKorf/CryptoExchange.Net) base library. Other exchange API implementations based on the CryptoExchange.Net base library are available and follow the same logic.

CryptoExchange.Net also allows for [easy access to different exchange API's](https://jkorf.github.io/CryptoExchange.Net/#idocs_shared).

|Exchange|Repository|Nuget|
|--|--|--|
|Binance|[JKorf/Binance.Net](https://github.com/JKorf/Binance.Net)|[![Nuget version](https://img.shields.io/nuget/v/Binance.net.svg?style=flat-square)](https://www.nuget.org/packages/Binance.Net)|
|BingX|[JKorf/BingX.Net](https://github.com/JKorf/BingX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.BingX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.BingX.Net)|
|Bitfinex|[JKorf/Bitfinex.Net](https://github.com/JKorf/Bitfinex.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bitfinex.net.svg?style=flat-square)](https://www.nuget.org/packages/Bitfinex.Net)|
|Bitget|[JKorf/Bitget.Net](https://github.com/JKorf/Bitget.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Bitget.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Bitget.Net)|
|BitMart|[JKorf/BitMart.Net](https://github.com/JKorf/BitMart.Net)|[![Nuget version](https://img.shields.io/nuget/v/BitMart.net.svg?style=flat-square)](https://www.nuget.org/packages/BitMart.Net)|
|Bybit|[JKorf/Bybit.Net](https://github.com/JKorf/Bybit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bybit.net.svg?style=flat-square)](https://www.nuget.org/packages/Bybit.Net)|
|CoinEx|[JKorf/CoinEx.Net](https://github.com/JKorf/CoinEx.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinEx.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinEx.Net)|
|CoinGecko|[JKorf/CoinGecko.Net](https://github.com/JKorf/CoinGecko.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinGecko.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinGecko.Net)|
|Gate.io|[JKorf/GateIo.Net](https://github.com/JKorf/GateIo.Net)|[![Nuget version](https://img.shields.io/nuget/v/GateIo.net.svg?style=flat-square)](https://www.nuget.org/packages/GateIo.Net)|
|HTX|[JKorf/HTX.Net](https://github.com/JKorf/HTX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.HTX.net.svg?style=flat-square)](https://www.nuget.org/packages/Jkorf.HTX.Net)|
|Gate.io|[JKorf/GateIo.Net](https://github.com/JKorf/GateIo.Net)|[![Nuget version](https://img.shields.io/nuget/v/GateIo.net.svg?style=flat-square)](https://www.nuget.org/packages/GateIo.Net)|
|Kraken|[JKorf/Kraken.Net](https://github.com/JKorf/Kraken.Net)|[![Nuget version](https://img.shields.io/nuget/v/KrakenExchange.net.svg?style=flat-square)](https://www.nuget.org/packages/KrakenExchange.Net)|
|Kucoin|[JKorf/Kucoin.Net](https://github.com/JKorf/Kucoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/Kucoin.net.svg?style=flat-square)](https://www.nuget.org/packages/Kucoin.Net)|
|Mexc|[JKorf/Mexc.Net](https://github.com/JKorf/Mexc.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Mexc.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Mexc.Net)|
|OKX|[JKorf/OKX.Net](https://github.com/JKorf/OKX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.OKX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.OKX.Net)|

When using multiple of these API's the [CryptoClients.Net](https://github.com/JKorf/CryptoClients.Net) package can be used which combines this and the other packages and allows easy access to all exchange API's.

## Discord
[![Discord](https://img.shields.io/discord/847020490588422145?style=for-the-badge)](https://discord.gg/MSpeEtSY8t)  
A Discord server is available [here](https://discord.gg/MSpeEtSY8t). For discussion and/or questions around the CryptoExchange.Net and implementation libraries, feel free to join.

## Supported functionality

*Due to framework restrictions for signing requests only .netstandard 2.1 can currently use private endpoints*

### Advanced Trade REST
|API|Supported|Location|
|--|--:|--|
|Account|✓|`restClient.AdvancedTradeApi.Account`|
|Products|✓|`restClient.AdvancedTradeApi.ExchangeData`|
|Orders|✓|`restClient.AdvancedTradeApi.Trading`|
|Portfolios|✓|`restClient.AdvancedTradeApi.Account`|
|Futures|✓|`restClient.AdvancedTradeApi.Account`/`restClient.AdvancedTradeApi.Trading`|
|Perpetuals|✓|`restClient.AdvancedTradeApi.Account`/`restClient.AdvancedTradeApi.Trading`|
|Fees|✓|`restClient.AdvancedTradeApi.Account`|
|Convert|✓|`restClient.AdvancedTradeApi.Account`|
|Public|✓|`restClient.AdvancedTradeApi.ExchangeData`|
|Payment Methods|✓|`restClient.AdvancedTradeApi.Account`|
|Data API|✓|`restClient.AdvancedTradeApi.Account`|

### Advanced Trade Websocket
|API|Supported|Location|
|--|--:|--|
|All channels|✓|`socketClient.AdvancedTradeApi`|

### App
|API|Supported|Location|
|--|--:|--|
|Accounts|X|*Functionality supported in Advanced Trade API*|
|Addresses|✓|`restClient.AdvancedTradeApi.Account`|
|Transactions|✓|`restClient.AdvancedTradeApi.Account`|
|Deposits|✓|`restClient.AdvancedTradeApi.Account`|
|Withdrawals|✓|`restClient.AdvancedTradeApi.Account`|
|Currencies|✓|`restClient.AdvancedTradeApi.ExchangeData`|
|Exchange Rates|✓|`restClient.AdvancedTradeApi.ExchangeData`|
|Prices|✓|`restClient.AdvancedTradeApi.ExchangeData`|
|Time|✓|`restClient.AdvancedTradeApi.ExchangeData`|

## Support the project
Any support is greatly appreciated.

### Donate
Make a one time donation in a crypto currency of your choice. If you prefer to donate a currency not listed here please contact me.

**Btc**:  bc1q277a5n54s2l2mzlu778ef7lpkwhjhyvghuv8qf  
**Eth**:  0xcb1b63aCF9fef2755eBf4a0506250074496Ad5b7   
**USDT (TRX)**  TKigKeJPXZYyMVDgMyXxMf17MWYia92Rjd 

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Release notes
* Version 1.0.1 - 14 Oct 2024
    * Updated CryptoExchange.Net to version 8.0.3, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.0.3
    * Fixed TypeLoadException during initialization
    * Fixed ICoinbaseOrderBookFactory DI lifetime

* Version 1.0.0 - 07 Oct 2024
    * Initial release
