using System;
namespace InfrastructureJanus
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository TestRepository { get; }

        int Complete();
    }
}
