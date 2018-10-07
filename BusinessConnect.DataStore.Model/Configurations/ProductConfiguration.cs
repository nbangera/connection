using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> configuration)
        {   //primarykey
            configuration.HasKey(t => t.Id);
            //autoincrement/identity. Not required as entity framework does it automatically
            configuration.Property(t => t.Id).ValueGeneratedOnAdd();
            

            configuration.Property(t => t.IsActive).HasDefaultValue(true);

            //will assign the current datatime value on add.
            configuration.Property(t => t.CreatedDate).HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd();

            //will assign the current datetime value on add or update
            configuration.Property(t => t.ModifiedDate).HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate();

            //Specifies the length of column and is NotNull
            configuration.Property(t => t.Name).HasMaxLength(100).IsRequired();
            //one to many
            //Product can belong to only one category
            //One Category has many products
            configuration.HasOne(t => t.Category).WithMany(t => t.Products).HasForeignKey(t=>t.ProductCategoryId).IsRequired();
            //one to many
            //Product can belong to one brand
            //Brand can have many products
            configuration.HasOne(t => t.Brand).WithMany(t => t.Products).HasForeignKey(t => t.BrandId).IsRequired();
            //One to One
            //ProductFile has a foreign key reference on Product using the ProductId
            configuration.HasOne(t => t.File).WithOne(t => t.Product).HasForeignKey<ProductFile>(t => t.ProductId).IsRequired();
        }
    }
}
