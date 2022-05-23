using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IClauseRepository : IRepository<Clause>
    {
        public Task<Clause> GetSpecific(string name);
    }
}
