using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;

namespace StarWarsRSN.WebApi.UseCases.ReportarTraidor
{
    public sealed class ReporteTraicaoRequest
    {
        public int ReporterPersonalNumber { get; set; }

        public int TraidorPersonalNumber { get; set; }
    }
}
