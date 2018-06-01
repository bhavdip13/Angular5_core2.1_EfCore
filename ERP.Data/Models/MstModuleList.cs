using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class MstModuleList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModuleName { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string CssClassName { get; set; }
    }
}
