namespace TanakBackend_ApplicationsService.Contract.Dtos.CategoryDto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? ParentId { get; set; }
    }
}
