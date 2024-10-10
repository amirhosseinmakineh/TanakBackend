using TanakBackend.Domain.Models;

namespace TanakBackend.Domain.Repositories
{
    public interface IBaseRepository<Tkey,Tentity> where Tkey : struct where Tentity : BaseEntity<Tkey>
    {
        void Add(Tentity tentity);
        void Update(Tentity tentity);
        void Delete(Tkey tkey);
        Tentity GetById(Tkey tkey);
        IQueryable<Tentity> GetAll();
        int SaveChanges();
    }
}
