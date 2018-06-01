using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Cmss
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public bool IncludeInFooter { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string PageName { get; set; }
        public bool Published { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
