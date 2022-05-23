using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface ILoginRepository : IRepository<Login>
    {
        public Task<Login> GetSpecific(string name);
    }
}
