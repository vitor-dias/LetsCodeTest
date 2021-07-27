namespace StarWarsRSN.Application.Queries
{
    using StarWarsRSN.Application.Results;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReporteTraidoresQueries
    {
        Task<List<ReporteResult>> GetReportes();
        Task<List<ReporteResult>> GetReportesId(int personalNumber);
    }
}
