using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Product_Metal_Mappings")]
    public partial class ProductMetalMappings
    {
        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public int MetalPurity { get; set; }
        public int MetalType { get; set; }
        public int ProductId { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Weight { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("ProductMetalMappings")]
        public Products Product { get; set; }
    }
}
