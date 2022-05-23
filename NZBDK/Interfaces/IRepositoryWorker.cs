using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IRepositoryWorker
    {
        IFieldRepository FieldRepository { get; }
        ISygnatureRepository SygnatureRepository { get; }
        IVariantRepository VariantRepository { get; }
        IRepository<Segment> SegmentRepository { get; }
    }
}
