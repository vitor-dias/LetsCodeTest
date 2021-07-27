using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StarWarsRSN.Domain.Rebeldes;

namespace StarWarsRSN.Domain.Rebeldes
{
    public sealed class Rebelde
    {
        [Key]
        [Required]
        public int PersonalNumber { get; set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Genero { get; private set; }

        public Localizacao Localizacao { get; set; }

        public List<Item> Inventario { get; set; }


        public Rebelde(int personalNumber,string nome, int idade, string genero, Localizacao localizacao, List<Item> inventario)
        {
            this.PersonalNumber = personalNumber;
            this.Nome = nome;
            this.Idade = idade;
            this.Genero = genero;
            this.Localizacao = localizacao;
            this.Inventario = inventario;
        }

        public Rebelde()
        {
        }

    }
}
