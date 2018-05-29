using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Product_Category_Mappings")]
    public partial class ProductCategoryMappings
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("ProductCategoryMappings")]
        public Categories Category { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ProductCategoryMappings")]
        public Products Product { get; set; }
    }
}
