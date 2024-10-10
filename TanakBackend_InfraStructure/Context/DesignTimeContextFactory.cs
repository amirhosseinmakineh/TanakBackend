using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TanakBackend_InfraStructure.Context;

namespace TanakBackend_InfraStructure.Context
{
    public class DesignTimeContextFactory
    {
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TanakContext>
        {

            public TanakContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<TanakContext>();
                builder.UseSqlServer("Data Source = .;Initial Catalog = TanakDb;Integrated Security = true;TrustServerCertificate = True");
                return new TanakContext(builder.Options);
            }
        }
    }
}
