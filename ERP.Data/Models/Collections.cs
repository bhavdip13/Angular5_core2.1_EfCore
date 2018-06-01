using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Collections
    {
        public Collections()
        {
            ProductCollectionMappings = new HashSet<ProductCollectionMappings>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public int? PictureId { get; set; }
        public bool ShowOnHomePage { get; set; }

        public Pictures Picture { get; set; }
        public ICollection<ProductCollectionMappings> ProductCollectionMappings { get; set; }
    }
}
