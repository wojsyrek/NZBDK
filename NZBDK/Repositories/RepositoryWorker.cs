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
        ISygnatureRepository? sygnatureRepository = null;
        IVariantRepository? variantRepository = null;
        ILoginRepository? loginRepository = null;
        IClauseRepository? clauseRepository = null;
        ISegmentRepository? segmentRepository = null;

        public ISegmentRepository SegmentRepository
        {
            get
            {
                if (segmentRepository == null)
                    segmentRepository = new SegmentRepository(_context);
                return segmentRepository;
            }
        }
        public ILoginRepository LoginRepository
        {
            get 
            {
                if (loginRepository == null)
                    loginRepository = new LoginRepository(_context);
                return loginRepository; 
            }
        }
        public IClauseRepository ClauseRepository
        {
            get
            {
                if (clauseRepository == null)
                    clauseRepository = new ClauseRepository(_context);
                return clauseRepository;
            }
        }
        public IFieldRepository FieldRepository
        {
            get
            {
                if (fieldRepository == null)
                    fieldRepository = new FieldRepository(_context);
                return fieldRepository;
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
