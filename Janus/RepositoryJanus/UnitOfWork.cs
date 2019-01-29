using System;
using InfrastructureJanus;

namespace RepositoryJanus
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JanusContext _context;

        public UnitOfWork(JanusContext context)
        {
            _context = context;

            TestRepository = new TestRepository(_context);
        }

        public ITestRepository TestRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
