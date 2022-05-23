using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly NzbdkDBContext _context;

        public SegmentRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        
        public async Task Add(Segment entity)
        {
            await _context.Segments.AddAsync(entity);
            await _context.SaveChangesAsync();
        } 
        public async Task Delete(Segment entity)
        {
            _context.Segments.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Segment entity)
        {
            _context.Segments.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Segment>> GetAll()
        {
            return await _context.Segments.ToListAsync<Segment>();
        }
        public async Task<Segment> GetSingle(int id)
        {
            return await _context.Segments.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
