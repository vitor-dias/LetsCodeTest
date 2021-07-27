namespace StarWarsRSN.Application.Repositories
{
    using StarWarsRSN.Domain.ReportTraidor;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReporteTraidorRepository
    {
        Task Add(ReporteTraidor reporte);
    }
}
