using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(400)]
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? PictureId { get; set; }
        public bool Published { get; set; }
        public bool ShowOnHomePage { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        [ForeignKey("ParentCategoryId")]
        [InverseProperty("InverseParentCategory")]
        public Categories ParentCategory { get; set; }
        [ForeignKey("PictureId")]
        [InverseProperty("Categories")]
        public Pictures Picture { get; set; }
        [InverseProperty("ParentCategory")]
        public ICollection<Categories> InverseParentCategory { get; set; }
        [InverseProperty("Category")]
        public ICollection<ProductCategoryMappings> ProductCategoryMappings { get; set; }
    }
}
