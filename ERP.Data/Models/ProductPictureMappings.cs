using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class ProductPictureMappings
    {
        public int Id { get; set; }
        public int DisplayOrder { get; set; }
        public int PictureId { get; set; }
        public int ProductId { get; set; }

        public Pictures Picture { get; set; }
        public Products Product { get; set; }
    }
}
