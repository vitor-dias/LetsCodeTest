
using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    public interface IUpdateLocalizacaoUseCase
    {
        Task<UpdateLocalizacaoResult> Execute(int personalNumber, Localizacao localizacao);
    }
}
