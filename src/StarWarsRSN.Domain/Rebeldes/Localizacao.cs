using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWarsRSN.Domain.Rebeldes
{
    public sealed class Localizacao
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string BaseAlocado { get; set; }
        public string Galaxia { get; set; }

        public Localizacao(double latitude, double longitude, string baseAlocado, string galaxia)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.BaseAlocado = baseAlocado;
            this.Galaxia = galaxia;
        }
        public Localizacao()
        {

        }
    }
}
