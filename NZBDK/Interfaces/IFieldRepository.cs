using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IFieldRepository : IRepository<Field>
    {
        public Task<IEnumerable<Field>> GetSpecific(Variant variant);
    }
}
