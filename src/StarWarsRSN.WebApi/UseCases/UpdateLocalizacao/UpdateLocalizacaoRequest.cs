using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;

namespace StarWarsRSN.WebApi.UseCases.UpdateLocalizacao
{
    public sealed class UpdateLocalizacaoRequest
    {
        public int PersonalNumber { get; set; }
        public Localizacao Localizacao { get; set; }
    }
}
