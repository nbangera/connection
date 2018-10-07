using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> brandConfiguration)
        {
            brandConfiguration.HasKey(t => t.Id);
            brandConfiguration.Property(t => t.Id).ValueGeneratedOnAdd();
            brandConfiguration.HasOne(t => t.Organisation).WithMany(t => t.Brands).HasForeignKey(t => t.OrganisationId).IsRequired();
            brandConfiguration.Property(t => t.Name).HasMaxLength(50).IsRequired();
        }
    }
}
