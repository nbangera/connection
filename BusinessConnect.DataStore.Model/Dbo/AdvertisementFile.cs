using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class AdvertisementFile:FileInfo
    {
       
        public int CampaignAdvertisementId { get; set; }

        public virtual CampaignAdvertisement CampaignAdvertisement { get; set; }

       
    }
}
