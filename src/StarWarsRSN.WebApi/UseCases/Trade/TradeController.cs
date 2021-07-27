namespace StarWarsRSN.WebApi.UseCases.Trade
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using StarWarsRSN.Application.Commands.Trade;
    using StarWarsRSN.WebApi.Model;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using StarWarsRSN.WebApi.UseCases.Register;
    using StarWarsRSN.Application.Repositories;

    [Route("api/[controller]")]
    public sealed class TradeController : Controller
    {
        private readonly ITradeUseCase RegisterService;
        private readonly IRebeldeRepository rebeldeRepository;

        public TradeController(ITradeUseCase registerService,IRebeldeRepository rebeldeRepository)
        {
            this.RegisterService = registerService;
            this.rebeldeRepository = rebeldeRepository;
        }

        [HttpPut]
        public async Task<IActionResult> Post([FromBody]TradeRequest request)
        {
            var rebelde1 = rebeldeRepository.Get(request.PersonalNumberTrader1).Result;
            var rebelde2 = rebeldeRepository.Get(request.PersonalNumberTrader2).Result;
            ExecuteTradeResult result = await RegisterService.Execute(rebelde1, rebelde2, request.ItensTrader1, request.ItensTrader2);

            TradeModel model = new TradeModel(result.tradeResult.Rebelde1, result.tradeResult.Rebelde2, result.tradeResult.ItensRebelde1, result.tradeResult.ItensRebelde2);

            return CreatedAtRoute("ExecuteTrade", model);
        }
    }
}
