using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly NzbdkDBContext _context;

        public LoginRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        public Task Add(Login entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Field>> GetSpecific(string name)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Login entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Login entity)
        {
            throw new NotImplementedException();
        }

        Task<Login> IRepository<Login>.GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Login>> IRepository<Login>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
