namespace TanakBackend_ApplicationsService.Contract.Dtos.CategoryDto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public int? ParentId { get; init; }
        public string ParentName { get; init; } = string.Empty;
        public bool HasChild { get; init; }
    }
}
