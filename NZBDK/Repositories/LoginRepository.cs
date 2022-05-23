using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly NzbdkDBContext _context;

        public LoginRepository(NzbdkDBContext context)
        {
            _context = context;
        }

        public async Task Add(Login entity)
        {
            await _context.Logins.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<Login> GetSpecific(string name)
        {
            return await _context.Logins.FirstOrDefaultAsync(o => o.Name == name);
        }

        public async Task Delete(Login entity)
        {
            _context.Logins.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Login entity)
        {
           _context.Logins.Update(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<Login> GetSingle(int id)
        {
            return await _context.Logins.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Login>> GetAll()
        {
            return await _context.Logins.ToListAsync<Login>();
        }
    }
}
