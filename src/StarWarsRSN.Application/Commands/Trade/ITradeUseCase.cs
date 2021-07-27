
using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StarWarsRSN.Application.Commands.Trade
{
    public interface ITradeUseCase
    {
        Task<ExecuteTradeResult> Execute(Rebelde trader1, Rebelde Trader2, List<Item> itensTrader1, List<Item> itensTrader2);
    }
}
