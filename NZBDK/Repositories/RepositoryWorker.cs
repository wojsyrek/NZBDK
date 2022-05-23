using NZBDK.Data;
using NZBDK.Interfaces;
using NZBDK.Models;

namespace NZBDK.Repositories
{
    public class RepositoryWorker : IRepositoryWorker
    {
        private readonly NzbdkDBContext _context;
        public RepositoryWorker(NzbdkDBContext context)
        {
            _context = context;
        }

        IFieldRepository? fieldRepository = null;
        IRepository<Segment>? segmentRepository = null;
        ISygnatureRepository? sygnatureRepository = null;
        IVariantRepository? variantRepository = null;

        public IFieldRepository FieldRepository
        {
            get
            {
                if (fieldRepository == null)
                    fieldRepository = new FieldRepository(_context);
                return fieldRepository;
            }
        }
        public IRepository<Segment> SegmentRepository
        {
            get
            {
                if (segmentRepository == null)
                    segmentRepository = new SegmentRepository(_context);
                return segmentRepository;
            }
        }
        public ISygnatureRepository SygnatureRepository
        {
            get
            {
                if (sygnatureRepository == null)
                    sygnatureRepository = new SygnatureRepository(_context);
                return sygnatureRepository;
            }
        }
        public IVariantRepository VariantRepository
        {
            get
            {
                if (variantRepository == null)
                    variantRepository = new VariantRepository(_context);
                return variantRepository;
            }
        }
    }
}
