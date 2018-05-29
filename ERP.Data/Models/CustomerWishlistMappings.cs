using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Customer_Wishlist_Mappings")]
    public partial class CustomerWishlistMappings
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("CustomerWishlistMappings")]
        public Customers Customer { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("CustomerWishlistMappings")]
        public Products Product { get; set; }
    }
}
