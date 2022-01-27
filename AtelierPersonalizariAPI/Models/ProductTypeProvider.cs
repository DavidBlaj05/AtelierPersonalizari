using System.ComponentModel.DataAnnotations;

namespace AtelierPersonalizariAPI.Models
{
    public class ProductTypeProvider : BaseEntity.BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }
}
