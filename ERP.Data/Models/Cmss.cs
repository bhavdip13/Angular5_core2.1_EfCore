using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("CMSs")]
    public partial class Cmss
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public bool IncludeInFooter { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(256)]
        public string PageName { get; set; }
        public bool Published { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
