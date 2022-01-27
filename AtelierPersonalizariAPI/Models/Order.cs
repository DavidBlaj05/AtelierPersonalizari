using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
