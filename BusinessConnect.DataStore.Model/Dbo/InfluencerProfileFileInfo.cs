using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class InfluencerProfileFileInfo:FileInfo
    {
        public int InfluencerID { get; set; }

        public virtual Influencer Influencer { get; set; }

    }
}
