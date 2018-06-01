using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductCollectionMappings
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public int DisplayOrder { get; set; }
        public int ProductId { get; set; }

        public Collections Collection { get; set; }
        public Products Product { get; set; }
    }
}
