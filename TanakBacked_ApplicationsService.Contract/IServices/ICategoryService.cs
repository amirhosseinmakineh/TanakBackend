using TanakBackend_ApplicationsService.Contract.Dtos.CategoryDto;

namespace TanakBackend_ApplicationsService.Contract.IServices
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAll(int? parentId);
    }
}
