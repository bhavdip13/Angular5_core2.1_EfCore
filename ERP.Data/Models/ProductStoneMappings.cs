using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductStoneMappings
    {
        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public int ProductId { get; set; }
        public decimal StoneCarat { get; set; }
        public int StoneClarityId { get; set; }
        public int StoneColorId { get; set; }
        public int StoneCutId { get; set; }
        public int StonePositionId { get; set; }
        public int StoneQuantity { get; set; }
        public int StoneShapeId { get; set; }
        public int StoneTypeId { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public Products Product { get; set; }
    }
}
