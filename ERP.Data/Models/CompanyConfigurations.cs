using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class CompanyConfigurations
    {
        public int Id { get; set; }
        [StringLength(400)]
        public string Address { get; set; }
        [Required]
        [StringLength(80)]
        public string ColorScheme { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(400)]
        public string Email { get; set; }
        [Required]
        public byte[] LogoBinary { get; set; }
        [Required]
        public byte[] MapBinary { get; set; }
        [StringLength(40)]
        public string MimeType { get; set; }
        [StringLength(18)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string OpeningHours { get; set; }
        [StringLength(18)]
        public string Phone { get; set; }
    }
}
