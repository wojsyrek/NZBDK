using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IRepositoryWorker
    {
        IFieldRepository FieldRepository { get; }
        ISygnatureRepository SygnatureRepository { get; }
        IVariantRepository VariantRepository { get; }
        ILoginRepository LoginRepository { get; }
        IClauseRepository ClauseRepository { get; }
        ISegmentRepository SegmentRepository { get; }
    }
}
