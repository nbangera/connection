using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class InfluencerCategory
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Influencer> Influencers { get; set; } = new HashSet<Influencer>();
    }
}
