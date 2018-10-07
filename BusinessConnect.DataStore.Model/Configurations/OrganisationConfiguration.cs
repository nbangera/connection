using BusinessConnect.DataStore.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Configurations
{
    public class OrganisationConfiguration: IEntityTypeConfiguration<Organisation>
    {
        public void Configure(EntityTypeBuilder<Organisation> organisationConfiguration)
        {
            organisationConfiguration.HasKey(t => t.Id);
            organisationConfiguration.Property(t => t.Name).HasMaxLength(50).IsRequired();
        }
    }
}
