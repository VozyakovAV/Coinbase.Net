﻿using Coinbase.Net.Objects.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Coinbase.Net.Objects.Internal
{
    internal record CoinbaseBatchTickerEvent : CoinbaseSocketEvent
    {
        [JsonPropertyName("tickers")]
        public IEnumerable<CoinbaseBatchTicker> Tickers { get; set; }
    }
}