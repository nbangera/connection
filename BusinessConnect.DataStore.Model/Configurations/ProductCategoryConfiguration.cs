using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class ProductCategoryConfiguration: IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> productCategoryConfiguration)
        {
            productCategoryConfiguration.HasKey(t => t.Id);
            productCategoryConfiguration.Property(t => t.Id).ValueGeneratedOnAdd();
            productCategoryConfiguration.Property(t => t.Name).HasMaxLength(50);
            //productCategoryConfiguration.HasMany(t => t.Products).WithOne(t => t.Category);



        }
    }
}
