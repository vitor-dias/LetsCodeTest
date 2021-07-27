namespace StarWarsRSN.WebApi.UseCases.Register
{
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.WebApi.Model;
    using System;
    using System.Collections.Generic;

    internal sealed class RebeldeModel
    {
        public int PersonalNumber { get; }
        public string Nome { get; }
        public int Idade { get; }
        public string Genero { get; }
        public Localizacao Localizacao { get; }
        public List<Item> Inventario { get; }

        public RebeldeModel(int personalNumber, string nome, int idade, string genero, Localizacao localizacao, List<Item> inventario)
        {
            this.PersonalNumber = personalNumber;
            this.Nome = nome;
            this.Idade = idade;
            this.Genero = genero;
            this.Localizacao = localizacao;
            this.Inventario = inventario;
        }
    }
}
