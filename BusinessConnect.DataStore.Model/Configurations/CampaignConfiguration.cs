using System;
using System.Collections.Generic;
using System.Text;
using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class CampaignConfiguration:IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> configuration)
        {
            configuration.HasKey(t => t.Id);
            configuration.Property(t => t.Id).ValueGeneratedOnAdd();
            configuration.Property(t => t.CreatedDate).ValueGeneratedOnAdd();
            //Default date will be updated on creation or update
            configuration.Property(t => t.ModifiedDate).ValueGeneratedOnAddOrUpdate();
            configuration.HasOne(t => t.Type).WithMany(t => t.Campaigns).HasForeignKey(t => t.CampaignTypeId).IsRequired();
        }
    }
}
