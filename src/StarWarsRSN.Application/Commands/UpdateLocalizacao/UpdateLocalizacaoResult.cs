namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    using StarWarsRSN.Application.Results;
    using StarWarsRSN.Domain.Rebeldes;
    using System.Collections.Generic;

    public sealed class UpdateLocalizacaoResult
    {
        public LocalizacaoResult localizacaoResult { get; }

        public UpdateLocalizacaoResult(int personalNumber,Localizacao localizacao)
        {
            localizacaoResult = new LocalizacaoResult(personalNumber,localizacao);
        }
    }
}
