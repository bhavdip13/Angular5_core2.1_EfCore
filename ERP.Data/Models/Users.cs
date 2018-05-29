using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public Guid UserGuid { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        [StringLength(80)]
        public string FullName { get; set; }
        public byte[] ProfilePicBinary { get; set; }
        [StringLength(40)]
        public string MimeType { get; set; }
    }
}
