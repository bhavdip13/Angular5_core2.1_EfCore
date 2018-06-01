using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductCategoryMappings
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int ProductId { get; set; }

        public Categories Category { get; set; }
        public Products Product { get; set; }
    }
}
