namespace StarWarsRSN.Application.Results
{
    using StarWarsRSN.Domain.Rebeldes;
    using System;
    using System.Collections.Generic;

    public sealed class LocalizacaoResult
    {
        public int PersonalNumber { get; }
        public Localizacao Localizacao { get; }

        public LocalizacaoResult(int personalNumber, Localizacao localizacao)
        {
            this.PersonalNumber = personalNumber;
            this.Localizacao = localizacao;
        }
    }
}
