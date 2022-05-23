using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class ClauseRepository : IClauseRepository
    {
        private readonly NzbdkDBContext _context;

        public ClauseRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Field>> GetSpecific(string name)
        {
            throw new NotImplementedException();
        }

        public Task Add(Clause entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Clause entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Clause entity)
        {
            throw new NotImplementedException();
        }

        Task<Clause> IRepository<Clause>.GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Clause>> IRepository<Clause>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
