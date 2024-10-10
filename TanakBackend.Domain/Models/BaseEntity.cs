using System.ComponentModel.DataAnnotations;

namespace TanakBackend.Domain.Models
{
    public class BaseEntity<Tkey> where Tkey : struct 
    {
        [Key]
        public Tkey Id { get; set; }
        public DateTime CreateObjectDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
