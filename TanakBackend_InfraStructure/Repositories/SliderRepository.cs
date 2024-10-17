using TanakBackend.Domain.IRepositoryies;
using TanakBackend.Domain.Models;
using TanakBackend_InfraStructure.Context;

namespace TanakBackend_InfraStructure.Repositories
{
    public class SliderRepository : BaseRepository<long, Slider>,ISliderrepository
    {
        public SliderRepository(TanakContext context) : base(context)
        {
        }
    }
}
