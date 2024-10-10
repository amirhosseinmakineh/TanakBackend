using TanakBackend.Domain.Models;
using TanakBackend.Domain.Repositories;
using TanakBackend_InfraStructure.Context;

namespace TanakBackend_InfraStructure.Repositories
{
    public class BaseRepository<Tkey, Tentity> : IBaseRepository<Tkey, Tentity> where Tkey : struct where Tentity : BaseEntity<Tkey>
    {
        private readonly TanakContext context;

        public BaseRepository(TanakContext context)
        {
            this.context = context;
        }

        public void Add(Tentity tentity)
        {
            context.Add(tentity);
        }

        public void Delete(Tkey tkey)
        {
           var entity = GetById(tkey);
            entity.IsDelete = true;
        }

        public IQueryable<Tentity> GetAll()
        {
            return context.Set<Tentity>();
        }

        public Tentity GetById(Tkey tkey)
        {
            return context.Set<Tentity>().Find();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update(Tentity tentity)
        {
            context.Update(tentity);
        }
    }
}
