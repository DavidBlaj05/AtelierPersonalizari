using System;
using System.ComponentModel.DataAnnotations;

namespace AtelierPersonalizariAPI.Models.DTOs
{
    public class ProductTypeDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Guid ProductTypeProviderId { get; set; }
    }
}
