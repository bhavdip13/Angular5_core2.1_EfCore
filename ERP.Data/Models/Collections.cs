using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(400)]
        public string Name { get; set; }
        public int? PictureId { get; set; }
        public bool ShowOnHomePage { get; set; }

        [ForeignKey("PictureId")]
        [InverseProperty("Collections")]
        public Pictures Picture { get; set; }
        [InverseProperty("Collection")]
        public ICollection<ProductCollectionMappings> ProductCollectionMappings { get; set; }
    }
}
