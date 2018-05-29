using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Inquiry_Product_Mappings")]
    public partial class InquiryProductMappings
    {
        public int Id { get; set; }
        public int InquiryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("InquiryId")]
        [InverseProperty("InquiryProductMappings")]
        public Inquirys Inquiry { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("InquiryProductMappings")]
        public Products Product { get; set; }
    }
}
