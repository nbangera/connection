using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Campaign> Campaigns { get; set; } = new HashSet<Campaign>();
    }
}
