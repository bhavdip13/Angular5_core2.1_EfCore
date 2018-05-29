using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [StringLength(40)]
        public string MimeType { get; set; }
        [Required]
        public byte[] PictureBinary { get; set; }
        [StringLength(300)]
        public string SeoFilename { get; set; }
        public string TitleAttribute { get; set; }

        [InverseProperty("Picture")]
        public ICollection<Categories> Categories { get; set; }
        [InverseProperty("Picture")]
        public ICollection<Collections> Collections { get; set; }
        [InverseProperty("Picture")]
        public ICollection<ProductPictureMappings> ProductPictureMappings { get; set; }
    }
}
