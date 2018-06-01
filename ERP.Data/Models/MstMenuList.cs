using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class MstMenuList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Modulename { get; set; }
        public string Menuname { get; set; }
        public string Url { get; set; }
        public string CssClassName { get; set; }
    }
}
