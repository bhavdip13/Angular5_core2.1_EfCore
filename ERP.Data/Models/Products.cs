using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Data.Models
{
    public partial class Products
    {
        public Products()
        {
            CustomerWishlistMappings = new HashSet<CustomerWishlistMappings>();
            InquiryProductMappings = new HashSet<InquiryProductMappings>();
            ProductCategoryMappings = new HashSet<ProductCategoryMappings>();
            ProductCollectionMappings = new HashSet<ProductCollectionMappings>();
            ProductMetalMappings = new HashSet<ProductMetalMappings>();
            ProductPictureMappings = new HashSet<ProductPictureMappings>();
            ProductProductTagMappings = new HashSet<ProductProductTagMappings>();
            ProductStoneMappings = new HashSet<ProductStoneMappings>();
        }

        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        [Required]
        [StringLength(30)]
        public string DesignCode { get; set; }
        public bool DisableInquiryButton { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Discount { get; set; }
        public DateTime? DiscountEndDateTimeUtc { get; set; }
        public DateTime? DiscountStartDateTimeUtc { get; set; }
        [Column(TypeName = "char(1)")]
        public string DiscountType { get; set; }
        public int DisplayOrder { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public string FullDescription { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Height { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Length { get; set; }
        public bool MarkAsNew { get; set; }
        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }
        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(400)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }
        public bool Published { get; set; }
        public string ShortDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        [StringLength(400)]
        public string Sku { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Weight { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Width { get; set; }

        [InverseProperty("Product")]
        public ICollection<CustomerWishlistMappings> CustomerWishlistMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<InquiryProductMappings> InquiryProductMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductCategoryMappings> ProductCategoryMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductCollectionMappings> ProductCollectionMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductMetalMappings> ProductMetalMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductPictureMappings> ProductPictureMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductProductTagMappings> ProductProductTagMappings { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductStoneMappings> ProductStoneMappings { get; set; }
    }
}
