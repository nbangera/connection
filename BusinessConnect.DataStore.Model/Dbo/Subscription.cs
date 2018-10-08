using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Subscription
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public bool IsExpired { get; set; } = false;

        public bool IsActive { get; set; } = true;

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Customer Customer { get; set; }

        public long CustomerId { get; set; }


        public virtual ICollection<PackageSubscription> PackageSubcriptions { get; set; }

    }
}
