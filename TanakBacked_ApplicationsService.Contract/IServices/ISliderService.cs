using TanakBackend_ApplicationsService.Contract.Dtos.Slider;

namespace TanakBackend_ApplicationsService.Contract.IServices
{
    public interface ISliderService
    {
        ICollection<SliderDto> GetAll();
    }
}
