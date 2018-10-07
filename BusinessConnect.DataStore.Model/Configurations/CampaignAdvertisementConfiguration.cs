using System;
using System.Collections.Generic;
using System.Text;
using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class CampaignAdvertisementConfiguration : IEntityTypeConfiguration<CampaignAdvertisement>
    {
        public void Configure(EntityTypeBuilder<CampaignAdvertisement> configuration)
        {
            configuration.HasKey(t => t.Id);
            configuration.Property(t => t.Id).ValueGeneratedOnAdd();
            configuration.Property(t => t.CreatedDate).ValueGeneratedOnAdd();
            configuration.Property(t => t.ModifiedDate).ValueGeneratedOnAddOrUpdate();
            configuration.Property(t => t.Title).HasMaxLength(100).IsRequired();
            configuration.Property(t => t.Description).HasMaxLength(500);
            //one to Many
            //CampaignAdvertisement Has one notnull Advertisement type, which has as foreignKey reference to AdvertisementTypeId
            configuration.HasOne(t => t.Type).WithMany(t => t.CampaignAdvertisements).HasForeignKey(t => t.AdvertisementTypeId).IsRequired();
            //One to One
            //AdvertisementFile has a foreign key reference to CampaignAdvertisement on CampaignAdvertisementId
            configuration.HasOne(t => t.File).WithOne(t => t.CampaignAdvertisement).HasForeignKey<AdvertisementFile>(t => t.CampaignAdvertisementId).IsRequired();
        }
    }
}
