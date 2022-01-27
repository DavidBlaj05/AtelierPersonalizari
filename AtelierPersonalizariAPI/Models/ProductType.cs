using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
