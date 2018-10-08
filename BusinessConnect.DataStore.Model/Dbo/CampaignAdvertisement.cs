using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignAdvertisement
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual AdvertisementFile File { get; set; }

        public virtual AdvertisementType Type { get; set; }
        public int AdvertisementTypeId { get; set; }

        public virtual Campaign Campaign { get; set; }
        public long CampaignId { get; set; }
    }
}
