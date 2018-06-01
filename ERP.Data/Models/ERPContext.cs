using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP.Data.Models
{
    public partial class ERPContext : DbContext
    {
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cmss> Cmss { get; set; }
        public virtual DbSet<Collections> Collections { get; set; }
        public virtual DbSet<CompanyConfigurations> CompanyConfigurations { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerWishlistMappings> CustomerWishlistMappings { get; set; }
        public virtual DbSet<InquiryProductMappings> InquiryProductMappings { get; set; }
        public virtual DbSet<Inquirys> Inquirys { get; set; }
        public virtual DbSet<MstMenuList> MstMenuList { get; set; }
        public virtual DbSet<MstModuleList> MstModuleList { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<ProductCategoryMappings> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductCollectionMappings> ProductCollectionMappings { get; set; }
        public virtual DbSet<ProductMetalMappings> ProductMetalMappings { get; set; }
        public virtual DbSet<ProductPictureMappings> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductProductTagMappings> ProductProductTagMappings { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductStoneMappings> ProductStoneMappings { get; set; }
        public virtual DbSet<ProductTags> ProductTags { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ERP;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.PictureId);
            });

            modelBuilder.Entity<Cmss>(entity =>
            {
                entity.ToTable("CMSs");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Collections>(entity =>
            {
                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.PictureId);
            });

            modelBuilder.Entity<CompanyConfigurations>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(400);

                entity.Property(e => e.ColorScheme)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LogoBinary).IsRequired();

                entity.Property(e => e.MapBinary).IsRequired();

                entity.Property(e => e.MimeType).HasMaxLength(40);

                entity.Property(e => e.Mobile).HasMaxLength(18);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.OpeningHours).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(18);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CustomerWishlistMappings>(entity =>
            {
                entity.ToTable("Customer_Wishlist_Mappings");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerWishlistMappings)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerWishlistMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<InquiryProductMappings>(entity =>
            {
                entity.ToTable("Inquiry_Product_Mappings");

                entity.HasOne(d => d.Inquiry)
                    .WithMany(p => p.InquiryProductMappings)
                    .HasForeignKey(d => d.InquiryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InquiryProductMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Inquirys>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Inquirys)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<MstMenuList>(entity =>
            {
                entity.ToTable("Mst_MenuList");

                entity.Property(e => e.CssClassName)
                    .HasColumnName("cssClassName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname)
                    .HasColumnName("menuname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modulename)
                    .HasColumnName("modulename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<MstModuleList>(entity =>
            {
                entity.ToTable("Mst_ModuleList");

                entity.Property(e => e.CssClassName).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.ModuleName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.Property(e => e.MimeType).HasMaxLength(40);

                entity.Property(e => e.PictureBinary).IsRequired();

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<ProductCategoryMappings>(entity =>
            {
                entity.ToTable("Product_Category_Mappings");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductCollectionMappings>(entity =>
            {
                entity.ToTable("Product_Collection_Mappings");

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.ProductCollectionMappings)
                    .HasForeignKey(d => d.CollectionId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCollectionMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductMetalMappings>(entity =>
            {
                entity.ToTable("Product_Metal_Mappings");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMetalMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductPictureMappings>(entity =>
            {
                entity.ToTable("Product_Picture_Mappings");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductProductTagMappings>(entity =>
            {
                entity.ToTable("Product_ProductTag_Mappings");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductTagId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.DesignCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountType).HasColumnType("char(1)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductStoneMappings>(entity =>
            {
                entity.ToTable("Product_Stone_Mappings");

                entity.Property(e => e.StoneCarat).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductStoneMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductTags>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(400);
            });

            modelBuilder.Entity<Subscribers>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FullName).HasMaxLength(80);

                entity.Property(e => e.MimeType).HasMaxLength(40);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });
        }
    }
}
