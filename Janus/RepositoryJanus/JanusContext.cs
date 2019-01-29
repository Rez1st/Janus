using Microsoft.EntityFrameworkCore;
using Model.Janus.Sql;

namespace RepositoryJanus
{
    public class JanusContext : DbContext
    {
        public JanusContext(DbContextOptions<JanusContext> options) : base(options)
        {
        }

        DbSet<TestClass> Tests { get; set; }
    }
}