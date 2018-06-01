using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class InquiryProductMappings
    {
        public int Id { get; set; }
        public int InquiryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Inquirys Inquiry { get; set; }
        public Products Product { get; set; }
    }
}
