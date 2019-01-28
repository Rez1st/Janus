using System;
using System.Collections.Generic;
using Model.Janus.Sql;

namespace InfrastructureJanus
{
    public interface ITestRepository : IRepository<TestClass>
    {
        IEnumerable<TestClass> GetTestClassesWithCustomLogic(int numberOfClassToget);
    }
}
