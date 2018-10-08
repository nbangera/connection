using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignApplication
    {
        public long Id { get; set; }

        public bool IsActive { get; set; } = true;

        public CampaignApplicationStatus Status { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public long CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }

        public virtual Influencer Influencer { get; set; }
        public long InfluencerId { get; set; }




    }
}
