using TanakBackend.Domain.IRepositoryies;
using TanakBackend_ApplicationsService.Contract.ConfigurationDtos;
using TanakBackend_ApplicationsService.Contract.Dtos.Slider;
using TanakBackend_ApplicationsService.Contract.IServices;

namespace TanakBackend.ApplicationService.Services
{
    public class SliderService : ISliderService
    {
        private readonly CdnConfiguration cdn;
        private readonly ISliderrepository repository;

        public SliderService(ISliderrepository repository)
        {
            this.repository = repository;
        }

        public ICollection<SliderDto> GetAll()
        {
            var images = repository.GetAll()
                .Select(x => new SliderDto()
                {
                    ImageName = x.ImageName,
                    Alt = x.Alt,
                    Id = x.Id
                }).ToList();
            return images;
        }
    }
}
