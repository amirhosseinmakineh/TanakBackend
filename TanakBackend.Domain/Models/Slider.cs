namespace TanakBackend.Domain.Models
{
    public class Slider:BaseEntity<long>
    {
        public string ImageName { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
    }
}
