using TanakBackend.Domain.IRepositoryies;
using TanakBackend_ApplicationsService.Contract.Dtos.CategoryDto;
using TanakBackend_ApplicationsService.Contract.IServices;

namespace TanakBackend.ApplicationService.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;

        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public List<CategoryDto> GetAll(int? parentId)
        {
            var categories = from category in repository.GetAll()
                             where category.PrentId == null
                             select new CategoryDto()
                             {
                                 Description = category.Description,
                                 ParentId = category.PrentId,
                                 Title = category.Title
                             };
           return categories.ToList();
        }
    }
}
