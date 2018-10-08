using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Package
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsActive { get; set; } = true;

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual PackageType PackageType { get; set; }
        public int PackageTypeId { get; set; }

        public virtual ICollection<PackageSubscription> PackageSubscriptions { get; set; }

    }
}
