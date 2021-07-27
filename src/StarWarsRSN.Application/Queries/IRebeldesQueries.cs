namespace StarWarsRSN.Application.Queries
{
    using StarWarsRSN.Application.Results;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRebeldesQueries
    {
        Task<RebeldeResult> GetRebelde(int RebeldeID);
        Task<List<RebeldeResult>> GetRebeldes();
    }
}
