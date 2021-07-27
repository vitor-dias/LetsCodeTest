
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsRSN.Application.Queries;
using StarWarsRSN.Application.Results;
using StarWarsRSN.Domain.Rebeldes;

namespace StarWarsRSN.Infrastructure.InMemoryDataAccess.Queries
{
    public class ReporteTraidoresQueries : IReporteTraidoresQueries
    {
        private readonly RSNContext _context;

        public ReporteTraidoresQueries(RSNContext context)
        {
            _context = context;
        }

        public async Task<List<ReporteResult>> GetReportes()
        {
            var reportes = new List<ReporteResult>();
            foreach (var reporte in _context.ReportesTraidores)
            {
                ReporteResult reporteResult = new ReporteResult(reporte);
                reportes.Add(reporteResult);
            }
            return await Task.FromResult<List<ReporteResult>>(reportes);
        }

        public async Task<List<ReporteResult>> GetReportesId(int personalNumber)
        {
            var reportes = new List<ReporteResult>();
            foreach (var reporte in _context.ReportesTraidores.Where(e => e.TraidorPersonalNumber == personalNumber))
            {
                ReporteResult reporteResult = new ReporteResult(reporte);
                reportes.Add(reporteResult);
            }
            return await Task.FromResult<List<ReporteResult>>(reportes);
        }
    }
}
