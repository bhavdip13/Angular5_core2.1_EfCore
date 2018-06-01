using System;
using System.Collections.Generic;

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
        public string DesignCode { get; set; }
        public bool DisableInquiryButton { get; set; }
        public decimal Discount { get; set; }
        public DateTime? DiscountEndDateTimeUtc { get; set; }
        public DateTime? DiscountStartDateTimeUtc { get; set; }
        public string DiscountType { get; set; }
        public int DisplayOrder { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public string FullDescription { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public bool MarkAsNew { get; set; }
        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }
        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Published { get; set; }
        public string ShortDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string Sku { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }

        public ICollection<CustomerWishlistMappings> CustomerWishlistMappings { get; set; }
        public ICollection<InquiryProductMappings> InquiryProductMappings { get; set; }
        public ICollection<ProductCategoryMappings> ProductCategoryMappings { get; set; }
        public ICollection<ProductCollectionMappings> ProductCollectionMappings { get; set; }
        public ICollection<ProductMetalMappings> ProductMetalMappings { get; set; }
        public ICollection<ProductPictureMappings> ProductPictureMappings { get; set; }
        public ICollection<ProductProductTagMappings> ProductProductTagMappings { get; set; }
        public ICollection<ProductStoneMappings> ProductStoneMappings { get; set; }
    }
}
