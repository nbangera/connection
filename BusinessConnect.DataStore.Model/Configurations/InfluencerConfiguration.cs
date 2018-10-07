using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class InfluencerConfiguration : IEntityTypeConfiguration<Influencer>
    {
        public void Configure(EntityTypeBuilder<Influencer> configuration)
        {
            configuration.HasKey(t => t.Id);
            configuration.Property(t => t.Id).ValueGeneratedOnAdd();
            configuration.HasOne(t => t.Category).WithMany(t => t.Influencers).HasForeignKey(t => t.InfluencerCategoryId).IsRequired();
            configuration.Property(t => t.ProfileSummary).HasMaxLength(500).IsRequired();
            configuration.Property(t => t.Title).HasMaxLength(100).IsRequired();
            configuration.HasOne(t => t.File).WithOne(t => t.Influencer).HasForeignKey<InfluencerProfileFileInfo>(t => t.InfluencerID).IsRequired();
        }
    }
}
