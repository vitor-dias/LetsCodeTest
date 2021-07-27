namespace StarWarsRSN.WebApi.UseCases.UpdateLocalizacao
{
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.WebApi.Model;
    using System;
    using System.Collections.Generic;

    internal sealed class LocalizacaoModel
    {
        public int PersonalNumber { get; }
        public Localizacao Localizacao { get; }

        public LocalizacaoModel(int personalNumber, Localizacao localizacao)
        {
            this.PersonalNumber = personalNumber;
            this.Localizacao = localizacao;
        }
    }
}
