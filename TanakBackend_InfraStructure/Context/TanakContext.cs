using Microsoft.EntityFrameworkCore;
using TanakBackend.Domain.Models;

namespace TanakBackend_InfraStructure.Context
{
    public class TanakContext : DbContext
    {
        public TanakContext(DbContextOptions<TanakContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
