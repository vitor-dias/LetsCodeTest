namespace StarWarsRSN.Application.Results
{
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.Domain.ReportTraidor;
    using System;
    using System.Collections.Generic;

    public sealed class ReporteResult
    {
        public int ReporterPersonalNumber { get; }
        public int TraidorPersonalNumber { get; }


        public ReporteResult(ReporteTraidor reporte)
        {
            this.ReporterPersonalNumber = reporte.ReporterPersonalNumber;
            this.TraidorPersonalNumber = reporte.TraidorPersonalNumber;
        }
    }
}
