using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public byte[] Password { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string FullName { get; set; }
        public byte[] ProfilePicBinary { get; set; }
        public string MimeType { get; set; }
    }
}
