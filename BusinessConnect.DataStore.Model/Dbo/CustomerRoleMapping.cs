using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CustomerRoleMapping
    {
        public long Id { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual Customer Customer { get; set; }
        public long CustomerId { get; set; }
    }
}
