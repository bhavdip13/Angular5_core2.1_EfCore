using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerWishlistMappings = new HashSet<CustomerWishlistMappings>();
            Inquirys = new HashSet<Inquirys>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public Guid CustomerGuid { get; set; }
        public bool Deleted { get; set; }
        [Required]
        [StringLength(400)]
        public string Email { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public string Password { get; set; }

        [InverseProperty("Customer")]
        public ICollection<CustomerWishlistMappings> CustomerWishlistMappings { get; set; }
        [InverseProperty("Customer")]
        public ICollection<Inquirys> Inquirys { get; set; }
    }
}
