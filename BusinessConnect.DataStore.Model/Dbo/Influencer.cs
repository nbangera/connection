using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Influencer
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ProfileSummary { get; set; }

        public string Facebook { get; set; }

        public string Twiter { get; set; }

        public virtual InfluencerCategory Category { get; set; }

        public virtual InfluencerProfileFileInfo File { get; set; }

        public int InfluencerCategoryId  { get; set; }

        public virtual User User { get; set; }
    }
}
