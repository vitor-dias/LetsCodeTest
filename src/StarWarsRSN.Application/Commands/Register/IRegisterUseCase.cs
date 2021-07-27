
using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    public interface IRegisterUseCase
    {
        Task<RegisterResult> Execute(int personalNumber, string nome, int idade, string genero, Localizacao localizacao, List<Item> inventario);
    }
}
