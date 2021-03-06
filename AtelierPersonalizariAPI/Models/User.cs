using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AtelierPersonalizariAPI.Models
{
    public class User : BaseEntity.BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(500)]
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
