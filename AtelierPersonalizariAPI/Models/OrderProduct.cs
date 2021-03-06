using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtelierPersonalizariAPI.Models
{
    public class OrderProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateModified { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
    }
}
