
using StarWarsRSN.Application.Results;
using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StarWarsRSN.Application.Commands.ReporteTraidor
{
    public interface IReporteTraidorUseCase
    {
        Task<ReporteResult> Execute(int reporterPersonalNumber, int traidorPersonalNumber);
    }
}
