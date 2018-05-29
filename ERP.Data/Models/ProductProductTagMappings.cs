using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Product_ProductTag_Mappings")]
    public partial class ProductProductTagMappings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductTagId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("ProductProductTagMappings")]
        public Products Product { get; set; }
        [ForeignKey("ProductTagId")]
        [InverseProperty("ProductProductTagMappings")]
        public ProductTags ProductTag { get; set; }
    }
}
