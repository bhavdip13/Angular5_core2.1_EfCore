using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("CustomerId")]
        [InverseProperty("Inquirys")]
        public Customers Customer { get; set; }
        [InverseProperty("Inquiry")]
        public ICollection<InquiryProductMappings> InquiryProductMappings { get; set; }
    }
}
