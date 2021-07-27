namespace StarWarsRSN.WebApi.UseCases.Trade
{
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.WebApi.Model;
    using System;
    using System.Collections.Generic;

    internal sealed class TradeModel
    {
        public Rebelde Trader1{ get; }
        public Rebelde Trader2 { get; }
        public List<Item> ItensTrader1 { get; }
        public List<Item> ItensTrader2 { get; }

        public TradeModel(Rebelde trader1, Rebelde trader2, List<Item> itensTrader1, List<Item> itensTrader2)
        {
            this.Trader1 = trader1;
            this.Trader2 = trader2;
            this.ItensTrader1 = itensTrader1;
            this.ItensTrader2 = itensTrader2;
        }
    }
}
