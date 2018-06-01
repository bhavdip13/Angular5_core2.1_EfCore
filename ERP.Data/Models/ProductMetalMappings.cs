using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductMetalMappings
    {
        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public int MetalPurity { get; set; }
        public int MetalType { get; set; }
        public int ProductId { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public decimal Weight { get; set; }

        public Products Product { get; set; }
    }
}
