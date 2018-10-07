using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Campaign
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Product Product { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual CampaignAdvertisement CampaignAdvertisement { get; set; }

        public virtual CampaignType Type { get; set; }

        public int CampaignTypeId { get; set; }
    }
}
