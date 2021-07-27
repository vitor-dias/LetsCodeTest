using StarWarsRSN.Domain.Rebeldes;
using System.Collections.Generic;

namespace StarWarsRSN.WebApi.UseCases.Register
{
    public sealed class AddRebeldeRequest
    {
        public int PersonalNumber { get; set; }
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public string Genero { get;  set; }
        public Localizacao Localizacao { get; set; }
        public List<Item> Inventario { get; set; }
    }
}
