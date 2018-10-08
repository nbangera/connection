using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class PackageSubscription
    {
        public long Id { get; set; }

        public Subscription Subscription { get; set; }
        public long SubscriptionId { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; }

    }
}
