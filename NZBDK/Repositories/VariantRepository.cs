using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;
namespace NZBDK.Repositories
{
    public class VariantRepository : IVariantRepository
    {
        private readonly NzbdkDBContext _context;

        public VariantRepository(NzbdkDBContext context)
        {
            _context = context;
        }
        public async Task Add(Variant entity)
        {
            await _context.Variants.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Variant entity)
        {
            _context.Variants.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Variant entity)
        {
            _context.Variants.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Variant>> GetSpecific(Sygnature sygnature)
        {
            return await _context.Variants.Where(o => sygnature.Id ==  o.Sygnature_Id).ToListAsync<Variant>();
        }
        public async Task<IEnumerable<Variant>> GetAll()
        {
            return await _context.Variants.ToListAsync();
        }
        public async Task<Variant?> GetSingle(int id)
        {
            return await _context.Variants.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
