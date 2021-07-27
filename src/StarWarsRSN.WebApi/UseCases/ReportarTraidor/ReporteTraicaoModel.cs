namespace StarWarsRSN.WebApi.UseCases.ReportarTraidor
{
    using StarWarsRSN.Domain.Rebeldes;
    using StarWarsRSN.WebApi.Model;
    using System;
    using System.Collections.Generic;

    internal sealed class ReporteTraicaoModel
    {
        public int ReporterPersonalNumber { get;}

        public int TraidorPersonalNumber { get;  }

        public ReporteTraicaoModel(int reporterPersonalNumber, int traidorPersonalNumber)
        {
            this.ReporterPersonalNumber = reporterPersonalNumber;
            this.TraidorPersonalNumber = traidorPersonalNumber;
        }
    }
}
