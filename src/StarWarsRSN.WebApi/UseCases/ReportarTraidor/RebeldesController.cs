
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using StarWarsRSN.Application.Commands.ReporteTraidor;
using StarWarsRSN.WebApi.Model;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarWarsRSN.WebApi.UseCases.ReportarTraidor;
using StarWarsRSN.Application.Results;

namespace StarWarsRSN.WebApi.UseCases.ReportarTraidor
{
    [Route("api/[controller]")]
    public sealed class ReportarTraicaoController : Controller
    {
        private readonly IReporteTraidorUseCase RegisterService;

        public ReportarTraicaoController(IReporteTraidorUseCase registerService)
        {
            this.RegisterService = registerService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ReporteTraicaoRequest request)
        {
            ReporteResult result = await RegisterService.Execute(request.ReporterPersonalNumber, request.TraidorPersonalNumber);

            ReporteTraicaoModel model = new ReporteTraicaoModel(result.ReporterPersonalNumber, result.TraidorPersonalNumber);

            return CreatedAtRoute("PostTraicao", new { TraidorReportado = model.TraidorPersonalNumber }, model);
        }
    }
}
