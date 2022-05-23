using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IClauseRepository : IRepository<Clause>
    {
        public Task<IEnumerable<Field>> GetSpecific(string name);
    }
}
