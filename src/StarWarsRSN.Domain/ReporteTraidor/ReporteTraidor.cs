using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWarsRSN.Domain.ReportTraidor
{
    public sealed class ReporteTraidor
    {
        [Key]
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
        public int ReporterPersonalNumber { get; set; }
        public int TraidorPersonalNumber { get; set; }
        [JsonIgnore]
        public DateTime ReportOcurrence { get; set; }

        public ReporteTraidor(int reporterPersonalNumber, int traidorPersonalNumber)
        {
            this.ReporterPersonalNumber = reporterPersonalNumber;
            this.TraidorPersonalNumber = traidorPersonalNumber;
        }


    }
}

