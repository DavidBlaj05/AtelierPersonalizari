using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierPersonalizariAPI.Models
{
    public class Order : BaseEntity.BaseEntity
    {
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PaymentProviderId { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
