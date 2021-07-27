namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    using System.Threading.Tasks;
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.Application.Repositories;
    using System.Collections.Generic;

    public sealed class RegisterUseCase : IRegisterUseCase
    {
        private readonly IRebeldeRepository rebeldeRepository;

        public RegisterUseCase(IRebeldeRepository rebeldeRepository)
        {
            this.rebeldeRepository = rebeldeRepository;
        }

        public async Task<RegisterResult> Execute(int personalNumber, string nome, int idade, string genero, Localizacao localizacao, List<Item> inventario)
        {
            var rebelde = new Rebelde(personalNumber, nome, idade, genero, localizacao, inventario);
            await rebeldeRepository.Add(rebelde);
            RegisterResult result = new RegisterResult(rebelde);
            return result;
        }
    }
}
