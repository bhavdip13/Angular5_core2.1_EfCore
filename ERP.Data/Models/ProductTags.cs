using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductTags
    {
        public ProductTags()
        {
            ProductProductTagMappings = new HashSet<ProductProductTagMappings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductProductTagMappings> ProductProductTagMappings { get; set; }
    }
}
