namespace StarWarsRSN.Application.Commands.ReporteTraidor
{
    using System.Threading.Tasks;
    using StarWarsRSN.Domain.ReportTraidor;
    using StarWarsRSN.Application.Repositories;
    using System.Collections.Generic;
    using StarWarsRSN.Application.Results;
    using System;

    public sealed class ReporteTraidorUseCase : IReporteTraidorUseCase
    {
        private readonly IReporteTraidorRepository Repository;

        public ReporteTraidorUseCase(IReporteTraidorRepository repository)
        {
            this.Repository = repository;
        }

        public async Task<ReporteResult> Execute(int reporterPersonalNumber, int traidorPersonalNumber)
        {
            var reporte = new ReporteTraidor(reporterPersonalNumber,traidorPersonalNumber);
            reporte.ReportOcurrence = DateTime.Now;
            await Repository.Add(reporte);
            ReporteResult result = new ReporteResult(reporte);
            return result;
        }
    }
}
