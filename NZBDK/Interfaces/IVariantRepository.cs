using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IVariantRepository : IRepository<Variant>
    {
        public Task<IEnumerable<Variant>> GetSpecific(Sygnature sygnature);
    }
}
