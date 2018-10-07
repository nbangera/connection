using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class AdvertisementType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<CampaignAdvertisement> CampaignAdvertisements { get; set; } = new HashSet<CampaignAdvertisement>();
    }
}
