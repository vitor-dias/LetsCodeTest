namespace StarWarsRSN.Application.Repositories
{
    using StarWarsRSN.Domain.Rebeldes;
    using System.Threading.Tasks;

    public interface IRebeldeRepository
    {
        Task<Rebelde> Get(int id);
        Task Add(Rebelde rebelde);
        Task Update(Rebelde rebelde);
    }
}
