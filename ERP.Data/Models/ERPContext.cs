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
                optionsBuilder.UseSqlServer(@"Server=.;Database=ERP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasIndex(e => e.ParentCategoryId);

                entity.HasIndex(e => e.PictureId);
            });

            modelBuilder.Entity<Collections>(entity =>
            {
                entity.HasIndex(e => e.PictureId);
            });

            modelBuilder.Entity<CustomerWishlistMappings>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<InquiryProductMappings>(entity =>
            {
                entity.HasIndex(e => e.InquiryId);

                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<Inquirys>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);
            });

            modelBuilder.Entity<ProductCategoryMappings>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<ProductCollectionMappings>(entity =>
            {
                entity.HasIndex(e => e.CollectionId);

                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<ProductMetalMappings>(entity =>
            {
                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<ProductPictureMappings>(entity =>
            {
                entity.HasIndex(e => e.PictureId);

                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<ProductProductTagMappings>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ProductTagId);
            });

            modelBuilder.Entity<ProductStoneMappings>(entity =>
            {
                entity.HasIndex(e => e.ProductId);
            });
        }
    }
}
