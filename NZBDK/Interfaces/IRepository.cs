using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Delete (T entity);
        Task Update (T entity);
        Task<T> GetSingle(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
