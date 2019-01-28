using System;
using System.Collections.Generic;
using InfrastructureJanus;
using Model.Janus.Sql;

namespace RepositoryJanus
{
    public class TestRepository : Repository<TestClass>, ITestRepository
    {
        public TestRepository(JanusContext context) : base(context)
        {
        }

        public IEnumerable<TestClass> GetTestClassesWithCustomLogic(int numberOfClassToget)
        {
            throw new NotImplementedException();
        }

        public JanusContext JanusContext { get { return Context as JanusContext; } }
    }
}
