
using StarWarsRSN.Domain.Rebeldes;
using System;
using System.Collections.Generic;
namespace StarWarsRSN.Application.Results
{
    public sealed class TradeResult
    {
        public Rebelde Rebelde1 { get; }
        public Rebelde Rebelde2 { get; }

        public List<Item> ItensRebelde1 { get; }
        public List<Item> ItensRebelde2 { get; }

        public TradeResult(Rebelde rebelde1, Rebelde rebelde2, List<Item> itensRebelde1, List<Item> itensRebelde2)
        {
            this.Rebelde1 = rebelde1;
            this.Rebelde2 = rebelde2;
            this.ItensRebelde1 = itensRebelde1;
            this.ItensRebelde2 = itensRebelde2;
        }
    }
}
