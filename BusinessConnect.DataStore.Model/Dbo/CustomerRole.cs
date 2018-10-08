using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CustomerRole
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public virtual ICollection<CustomerRolePermissionMapping> CustomerRolePermissionMappings { get; set; } = new HashSet<CustomerRolePermissionMapping>();
    }
}
