namespace StarWarsRSN.Application.Commands.UpdateLocalizacao
{
    using StarWarsRSN.Application.Results;
    using StarWarsRSN.Domain.Rebeldes;
    using System.Collections.Generic;

    public sealed class RegisterResult
    {
        public RebeldeResult Rebelde { get; }

        public RegisterResult(Rebelde rebelde)
        {
            Rebelde = new RebeldeResult(rebelde.PersonalNumber,rebelde.Nome, rebelde.Idade, rebelde.Genero, rebelde.Localizacao, rebelde.Inventario);
        }
    }
}
