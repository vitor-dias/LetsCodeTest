namespace StarWarsRSN.Application.Commands.Trade
{
    using StarWarsRSN.Application.Results;
    using StarWarsRSN.Domain.Rebeldes;
    using System.Collections.Generic;

    public sealed class ExecuteTradeResult
    {
        public TradeResult tradeResult { get; }

        public ExecuteTradeResult(Rebelde rebelde1, Rebelde rebelde2, List<Item> itensRebelde1, List<Item> itensRebelde2)
        {
            tradeResult = new TradeResult(rebelde1,rebelde2,itensRebelde1,itensRebelde2);
        }
    }
}
