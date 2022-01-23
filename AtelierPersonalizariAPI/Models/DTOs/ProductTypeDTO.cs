using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
