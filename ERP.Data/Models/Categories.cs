using System;
using System.Collections.Generic;

namespace ERP.Data.Models
{
    public partial class Categories
    {
        public Categories()
        {
            InverseParentCategory = new HashSet<Categories>();
            ProductCategoryMappings = new HashSet<ProductCategoryMappings>();
        }

        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? PictureId { get; set; }
        public bool Published { get; set; }
        public bool ShowOnHomePage { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public Categories ParentCategory { get; set; }
        public Pictures Picture { get; set; }
        public ICollection<Categories> InverseParentCategory { get; set; }
        public ICollection<ProductCategoryMappings> ProductCategoryMappings { get; set; }
    }
}
