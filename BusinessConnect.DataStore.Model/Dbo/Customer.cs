using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Customer
    {
        public long Id { get; set; }

             

        public virtual User User { get; set; }
        public long UserId { get; set; }

        public virtual ICollection<CustomerRoleMapping> Roles { get; set; } = new HashSet<CustomerRoleMapping>();
        public virtual ICollection<Subscription> Subscriptions { get; set; } = new HashSet<Subscription>();
    }
}
