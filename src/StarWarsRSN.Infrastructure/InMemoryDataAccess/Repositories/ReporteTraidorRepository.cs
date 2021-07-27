
using StarWarsRSN.Application.Repositories;
using StarWarsRSN.Domain.ReportTraidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StarWarsRSN.Infrastructure.InMemoryDataAccess.Repositories
{
    public class ReporteTraidorRepository : IReporteTraidorRepository
    {
        private readonly RSNContext _context;

        public ReporteTraidorRepository(RSNContext context)
        {
            _context = context;
        }

        public async Task Add(ReporteTraidor reporte)
        {
            _context.ReportesTraidores.Add(reporte);
            _context.SaveChanges();
            await Task.CompletedTask;
        }

    }
}
