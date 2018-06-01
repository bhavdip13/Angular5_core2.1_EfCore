using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class CompanyConfigurations
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ColorScheme { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public byte[] LogoBinary { get; set; }
        public byte[] MapBinary { get; set; }
        public string MimeType { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string OpeningHours { get; set; }
        public string Phone { get; set; }
    }
}
