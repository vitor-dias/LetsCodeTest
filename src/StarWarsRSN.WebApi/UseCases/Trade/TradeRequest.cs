using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;

namespace StarWarsRSN.WebApi.UseCases.Trade
{
    public sealed class TradeRequest
    {
        public int PersonalNumberTrader1 { get; set; }
        public int PersonalNumberTrader2 { get; set; }
        public List<Item> ItensTrader1 { get; set; }
        public List<Item> ItensTrader2 { get; set; }
    }
}
