namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    using System.Threading.Tasks;
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.Application.Repositories;
    using System.Collections.Generic;

    public sealed class UpdateLocalizacaoUseCase : IUpdateLocalizacaoUseCase
    {
        private readonly IRebeldeRepository rebeldeRepository;

        public UpdateLocalizacaoUseCase(IRebeldeRepository rebeldeRepository)
        {
            this.rebeldeRepository = rebeldeRepository;
        }

        public async Task<UpdateLocalizacaoResult> Execute(int personalNumber, Localizacao localizacao)
        {
            var rebelde = rebeldeRepository.Get(personalNumber).Result;
            rebelde.Localizacao = localizacao;
            await rebeldeRepository.Update(rebelde);
            UpdateLocalizacaoResult result = new UpdateLocalizacaoResult(rebelde.PersonalNumber,localizacao);
            return result;
        }
    }
}
