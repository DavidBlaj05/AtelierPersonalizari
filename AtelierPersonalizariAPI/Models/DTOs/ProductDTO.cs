using System;
using System.ComponentModel.DataAnnotations;

namespace AtelierPersonalizariAPI.Models.DTOs
{
    public class ProductDTO
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
    }
}
