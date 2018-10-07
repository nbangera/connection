using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignApplication
    {
        public long Id { get; set; }

        public long CampaignId { get; set; }

        public virtual Campaign Campaign { get; set; }

        public virtual Influencer Influencer { get; set; }


    }
}
