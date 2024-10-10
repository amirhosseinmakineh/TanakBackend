using TanakBackend.Domain.Models;
using TanakBackend.Domain.Repositories;

namespace TanakBackend.Domain.IRepositoryies
{
    public interface ICategoryRepository:IBaseRepository<int,Category>
    {
    }
}
