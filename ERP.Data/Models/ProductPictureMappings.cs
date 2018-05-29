using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    [Table("Product_Picture_Mappings")]
    public partial class ProductPictureMappings
    {
        public int Id { get; set; }
        public int DisplayOrder { get; set; }
        public int PictureId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("PictureId")]
        [InverseProperty("ProductPictureMappings")]
        public Pictures Picture { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ProductPictureMappings")]
        public Products Product { get; set; }
    }
}
