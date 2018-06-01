using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Pictures
    {
        public Pictures()
        {
            Categories = new HashSet<Categories>();
            Collections = new HashSet<Collections>();
            ProductPictureMappings = new HashSet<ProductPictureMappings>();
        }

        public int Id { get; set; }
        public string AltAttribute { get; set; }
        public bool IsNew { get; set; }
        public string MimeType { get; set; }
        public byte[] PictureBinary { get; set; }
        public string SeoFilename { get; set; }
        public string TitleAttribute { get; set; }

        public ICollection<Categories> Categories { get; set; }
        public ICollection<Collections> Collections { get; set; }
        public ICollection<ProductPictureMappings> ProductPictureMappings { get; set; }
    }
}
