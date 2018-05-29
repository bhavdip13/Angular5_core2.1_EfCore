using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Product_Collection_Mappings")]
    public partial class ProductCollectionMappings
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public int DisplayOrder { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("CollectionId")]
        [InverseProperty("ProductCollectionMappings")]
        public Collections Collection { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ProductCollectionMappings")]
        public Products Product { get; set; }
    }
}
