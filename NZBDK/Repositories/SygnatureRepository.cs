using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories

{
    public class SygnatureRepository : ISygnatureRepository
    {
        private readonly NzbdkDBContext _context;

        public SygnatureRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        public async Task Add(Sygnature entity)
        {
            await _context.Sygnatures.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Sygnature entity)
        {
            _context.Sygnatures.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Sygnature entity)
        {
            _context.Sygnatures.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Sygnature>> GetSpecific(Segment segment)
        {
            return await _context.Sygnatures.Where(x => x.Segment_Id == segment.Id).ToListAsync<Sygnature>();
        }
        public async Task<IEnumerable<Sygnature>> GetAll()
        {
            return await _context.Sygnatures.ToListAsync<Sygnature>();
        }
        public async Task<Sygnature?> GetSingle(int id)
        {
            return await _context.Sygnatures.SingleOrDefaultAsync(x => x.Id == id);
        }
        
    }
}
