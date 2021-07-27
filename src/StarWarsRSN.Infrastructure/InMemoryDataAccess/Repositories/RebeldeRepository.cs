
using StarWarsRSN.Application.Repositories;
using StarWarsRSN.Domain.Rebeldes;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace StarWarsRSN.Infrastructure.InMemoryDataAccess.Repositories
{
    public class RebeldeRepository : IRebeldeRepository
    {
        private readonly RSNContext _context;

        public RebeldeRepository(RSNContext context)
        {
            _context = context;
        }

        public async Task Add(Rebelde customer)
        {
            _context.Rebeldes.Add(customer);
            _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task<Rebelde> Get(int id)
        {
            Rebelde rebelde = _context.Rebeldes
                .Where(e => e.PersonalNumber == id)
                .SingleOrDefault();

            return await Task.FromResult<Rebelde>(rebelde);
        }

        public async Task Update(Rebelde customer)
        {
            Rebelde customerOld = _context.Rebeldes
                .Where(e => e.PersonalNumber == customer.PersonalNumber)
                .SingleOrDefault();

            customerOld = customer;
            await Task.CompletedTask;
        }
    }
}
