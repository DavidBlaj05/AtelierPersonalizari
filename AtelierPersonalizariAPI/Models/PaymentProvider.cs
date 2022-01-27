using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AtelierPersonalizariAPI.Models
{
    public class PaymentProvider : BaseEntity.BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
