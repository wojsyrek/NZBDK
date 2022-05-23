using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface ILoginRepository : IRepository<Login>
    {
        public Task<IEnumerable<Field>> GetSpecific(string name);
    }
}
