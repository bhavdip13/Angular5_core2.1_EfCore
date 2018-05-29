using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class Subscribers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(400)]
        public string Email { get; set; }
    }
}
