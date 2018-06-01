using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Inquirys
    {
        public Inquirys()
        {
            InquiryProductMappings = new HashSet<InquiryProductMappings>();
        }

        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CustomerId { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public Customers Customer { get; set; }
        public ICollection<InquiryProductMappings> InquiryProductMappings { get; set; }
    }
}
