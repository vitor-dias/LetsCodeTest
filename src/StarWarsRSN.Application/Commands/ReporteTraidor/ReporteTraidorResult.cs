using StarWarsRSN.Application.Results;
using System.Collections.Generic;
using StarWarsRSN.Domain.ReportTraidor;
namespace StarWarsRSN.Application.Commands.ReporteTraidor
{

    public sealed class ReporteTraidorResult
    {
        public ReporteResult Reporte { get; }

        public ReporteTraidorResult(Domain.ReportTraidor.ReporteTraidor reporte)
        {
            Reporte = new ReporteResult(reporte);

        }
    }
}
