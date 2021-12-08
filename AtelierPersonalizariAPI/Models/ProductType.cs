using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierPersonalizariAPI.Models
{
    public class ProductType : BaseEntity.BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid ProductTypeProviderId { get; set; }
        public ProductTypeProvider ProductTypeProvider { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
