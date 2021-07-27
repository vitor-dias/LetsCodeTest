
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsRSN.Application.Queries;
using StarWarsRSN.Application.Results;
using StarWarsRSN.Domain.Rebeldes;

namespace StarWarsRSN.Infrastructure.InMemoryDataAccess.Queries
{
    public class RebeldesQueries : IRebeldesQueries
    {
        private readonly RSNContext _context;

        public RebeldesQueries(RSNContext context)
        {
            _context = context;
        }

        public async Task<RebeldeResult> GetRebelde(int rebeldeId)
        {
            Rebelde rebelde = _context
                .Rebeldes
                .Where(e => e.PersonalNumber == rebeldeId)
                .FirstOrDefault();

            if (rebelde == null)
                throw new InfrastructureException($"O Rebelde {rebeldeId} não foi encontrado.");


            RebeldeResult rebeldeResult = new RebeldeResult(rebelde.PersonalNumber, rebelde.Nome, rebelde.Idade, rebelde.Genero, rebelde.Localizacao, rebelde.Inventario);

            return await Task.FromResult<RebeldeResult>(rebeldeResult);
        }

        public async Task<List<RebeldeResult>> GetRebeldes()
        {
            var rebeldes = new List<RebeldeResult>();
            foreach (var rebelde in _context.Rebeldes)
            {
                RebeldeResult rebeldeResult = new RebeldeResult(rebelde.PersonalNumber, rebelde.Nome, rebelde.Idade, rebelde.Genero, rebelde.Localizacao, rebelde.Inventario);
                rebeldes.Add(rebeldeResult);
            }
            return await Task.FromResult<List<RebeldeResult>>(rebeldes);
        }
    }
}
