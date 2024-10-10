using System.ComponentModel.DataAnnotations;

namespace TanakBackend.Domain.Models
{
    public class Category:BaseEntity<int>
    {
        public Category()
        {
            Categories = new HashSet<Category>();
        }
        [MaxLength(46)]
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? PrentId { get; set; }
        #region Relations
        public Category ParentCategory { get; set; }
        public ICollection<Category> Categories { get; set; }
        #endregion

    }
}
