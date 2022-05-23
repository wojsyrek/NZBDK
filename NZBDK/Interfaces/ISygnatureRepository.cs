using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface ISygnatureRepository : IRepository<Sygnature>
    {
        public Task<IEnumerable<Sygnature>> GetSpecific(Segment segment);
    }
}
