using TanakBackend.Domain.IRepositoryies;
using TanakBackend.Domain.Models;
using TanakBackend.Domain.Repositories;
using TanakBackend_InfraStructure.Context;

namespace TanakBackend_InfraStructure.Repositories
{
    public class CategoryRepository : BaseRepository<int, Category>,ICategoryRepository
    {
        public CategoryRepository(TanakContext context) : base(context)
        {
        }
    }
}
