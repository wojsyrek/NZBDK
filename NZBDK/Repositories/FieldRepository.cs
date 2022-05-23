using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class FieldRepository : IFieldRepository
    {
        private readonly NzbdkDBContext _context;

        public FieldRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        public async Task Add(Field entity)
        {
            await _context.Fields.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Field entity)
        {
            _context.Fields.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Field entity)
        {
            _context.Fields.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Field>> GetSpecific(Variant variant)
        {
            return await _context.Fields.Where(o => o.Variant_Id == variant.Id).ToListAsync<Field>();
        }
        public async Task<IEnumerable<Field>> GetAll()
        {
            return await _context.Fields.ToListAsync();
        }
        public async Task<Field> GetSingle(int id)
        {
            return await _context.Fields.SingleOrDefaultAsync(f => f.Id == id);
        }
    }
}
