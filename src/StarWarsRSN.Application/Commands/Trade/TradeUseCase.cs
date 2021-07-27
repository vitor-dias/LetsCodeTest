namespace StarWarsRSN.Application.Commands.Trade
{
    using System.Threading.Tasks;
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.Application.Repositories;
    using System.Collections.Generic;
    using StarWarsRSN.Application.Queries;
    using System.Linq;

    public sealed class TradeUseCase : ITradeUseCase
    {
        private readonly IRebeldeRepository RebeldeRepository;
        private readonly IReporteTraidoresQueries ReporteTraidoresQueries;

        public TradeUseCase(IRebeldeRepository rebeldeRepository, Queries.IReporteTraidoresQueries reporteTraidoresQueries)
        {
            this.RebeldeRepository = rebeldeRepository;
            this.ReporteTraidoresQueries = reporteTraidoresQueries;
        }

        public async Task<ExecuteTradeResult> Execute(Rebelde trader1, Rebelde trader2, List<Item> itensTrader1, List<Item> itensTrader2)
        {
            if (RebeldeTraidor(trader1))
            {
                throw new ApplicationException($"O Rebelde {trader1.Nome} é um traidor, seu inventário está congelado");
            }
            if (RebeldeTraidor(trader2))
            {
                throw new ApplicationException($"O Rebelde {trader2.Nome} é um traidor, seu inventário está congelado");
            }
            var totaltrader1 = itensTrader1.Sum(v => v.GetValor());
            var totaltrader2 = itensTrader2.Sum(v => v.GetValor());

            if (totaltrader1 != totaltrader2)
            {
                throw new ApplicationException($"O total oferecido pelo rebelde {trader1.Nome} ({totaltrader1}) não é o mesmo do oferecido pelo rebelde {trader2.Nome} ({totaltrader2})");
            }

            MoverItens(trader1, itensTrader1, itensTrader2);
            MoverItens(trader2, itensTrader2, itensTrader1);

            await RebeldeRepository.Update(trader1);
            await RebeldeRepository.Update(trader2);
            ExecuteTradeResult result = new ExecuteTradeResult(trader1, trader2, itensTrader1, itensTrader2);
            return result;
        }

        private void MoverItens(Rebelde trader, List<Item> itensEnviados, List<Item> itensRecebidos)
        {
            HashSet<string> itensremovidostrader = new HashSet<string>(itensEnviados.Select(x => x.Nome));
            trader.Inventario.RemoveAll(x => itensremovidostrader.Contains((x.Nome)));
            trader.Inventario.AddRange(itensRecebidos);
        }

        private bool RebeldeTraidor(Rebelde rebelde)
        {
            var reports = ReporteTraidoresQueries.GetReportesId(rebelde.PersonalNumber);
            return reports?.Result?.Count >= 3;
        }

    }
}
