namespace StarWarsRSN.Application.Results
{
    using StarWarsRSN.Domain.Rebeldes;
    using System;
    using System.Collections.Generic;

    public sealed class RebeldeResult
    {
        public int PersonalNumber { get; }
        public string Nome { get; }
        public int Idade { get; }
        public string Genero { get; }
        public Localizacao Localizacao { get; }
        public List<Item> Inventario { get; }

        public RebeldeResult(int personalNumber, string nome, int idade, string genero, Localizacao localizacao, List<Item> inventario)
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
