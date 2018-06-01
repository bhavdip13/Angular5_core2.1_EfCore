using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductProductTagMappings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductTagId { get; set; }

        public Products Product { get; set; }
        public ProductTags ProductTag { get; set; }
    }
}
