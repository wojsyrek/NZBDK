using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Clause entity)
        {
            await _context.Clauses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<Clause> GetSpecific(string name)
        {
            return await _context.Clauses.FirstOrDefaultAsync(o => o.Name == name);
        }

        public async Task Delete(Clause entity)
        {
            _context.Clauses.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Clause entity)
        {
            _context.Clauses.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Clause> GetSingle(int id)
        {
            return await _context.Clauses.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Clause>> GetAll()
        {
            return await _context.Clauses.ToListAsync<Clause>();
        }
    }
}
