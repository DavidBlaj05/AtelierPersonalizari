using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AtelierPersonalizariAPI.Models
{
    public class Product : BaseEntity.BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Guid ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
