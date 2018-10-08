using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignInfluencerStatistic
    {
        public long Id { get; set; }

        public string FacebookShare { get; set; }

        public string LinkedinShare { get; set; }

        public string GmailInvite { get; set; }

        public Campaign Campaign { get; set; }

        public long CampaignId { get; set; }

        public Influencer Influencer { get; set; }

        public long InfluencerId { get; set; }

    }
}
