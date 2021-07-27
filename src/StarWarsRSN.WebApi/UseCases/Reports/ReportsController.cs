namespace StarWarsRSN.WebApi.UseCases.Reports
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using StarWarsRSN.WebApi.Model;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using StarWarsRSN.WebApi.UseCases.Register;
    using StarWarsRSN.Application.Repositories;
    using StarWarsRSN.Application.Queries;
    using System.Linq;
    using StarWarsRSN.Domain.Rebeldes;
    using System;

    [Route("api/[controller]")]
    public sealed class ReportsController : Controller
    {
        private readonly IRebeldesQueries Rebeldes;
        private readonly IReporteTraidoresQueries ReporteTraidoresQueries;

        public ReportsController(IRebeldesQueries rebeldes, IReporteTraidoresQueries reporteTraidoresQueries)
        {
            this.Rebeldes = rebeldes;
            this.ReporteTraidoresQueries = reporteTraidoresQueries;
        }

        [HttpGet]
        public async Task<IActionResult> RebeldesSummary()
        {
            var rebeldes = this.Rebeldes.GetRebeldes().Result;
            var reportes = this.ReporteTraidoresQueries.GetReportes().Result;
            var traidores = reportes.GroupBy(x => x.TraidorPersonalNumber, x => 1).Select(group => new { Traidor = group.Key, qtd = group.Count() }).Where(qtd => qtd.qtd >= 3);

            var mediaRecursos = new List<(eTipo Tipo, int Media)>();
            foreach (eTipo tipo in (eTipo[])Enum.GetValues(typeof(eTipo)))
            {
                var entries = new List<int>();
                foreach (var rebelde in rebeldes)
                {
                    entries.Add(rebelde.Inventario.Where(t => t.Tipo == tipo).Count());
                }
                mediaRecursos.Add((tipo, (int)entries.Average()));
            }
            HashSet<int> traidoreshash = new HashSet<int>(traidores.Select(x => x.Traidor));

            var rebeldesTraidores = rebeldes.Where(s => traidoreshash.Contains(s.PersonalNumber));
            int pontosPerdidos = 0;
            foreach (var traidor in rebeldesTraidores)
            {
                pontosPerdidos += traidor.Inventario.Sum(x => x.GetValor());
            }
            var porcentagemRebeldes = ((decimal)(rebeldes.Count() - traidores.Count()) / rebeldes.Count).ToString("P");
            var porcentagemTraidores = ((decimal)traidores.Count() / rebeldes.Count).ToString("P");

            return Ok(new { porcentagemRebeldes, porcentagemTraidores, V = mediaRecursos.Select(x => new { Tipo = x.Tipo.ToString(), Media = x.Media }) , pontosPerdidos});
        }
    }
}
