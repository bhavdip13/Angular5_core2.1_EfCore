using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class CustomerWishlistMappings
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public Customers Customer { get; set; }
        public Products Product { get; set; }
    }
}
