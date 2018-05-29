using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class ProductTags
    {
        public ProductTags()
        {
            ProductProductTagMappings = new HashSet<ProductProductTagMappings>();
        }

        public int Id { get; set; }
        [StringLength(400)]
        public string Name { get; set; }

        [InverseProperty("ProductTag")]
        public ICollection<ProductProductTagMappings> ProductProductTagMappings { get; set; }
    }
}
