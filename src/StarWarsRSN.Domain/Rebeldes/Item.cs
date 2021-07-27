using EnumsNET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWarsRSN.Domain.Rebeldes
{
    public enum eTipo
    {
        [Description("Arma")] Arma,
        [Description("Munição")]Municao,
        [Description("Água")] Agua,
        [Description("Comida")] Comida
    }


    public sealed class Item
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public eTipo Tipo { get; set; }

        private Dictionary<eTipo, int> itensValue = new Dictionary<eTipo, int>()
        {
            { eTipo.Arma, 4},
            { eTipo.Municao, 3},
            { eTipo.Agua, 2},
            { eTipo.Comida, 1}
        };

        public int GetValor()
        {
            return this.itensValue[this.Tipo];
        }

        public override string ToString()
        {
            string description = ((eTipo)Tipo).AsString(EnumFormat.Description);
            return description;
        }

        public Item()
        {

        }

        public Item(string nome, eTipo tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

    }
}
