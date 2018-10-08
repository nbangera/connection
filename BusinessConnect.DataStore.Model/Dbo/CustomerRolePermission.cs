using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CustomerRolePermission
    {
        public CustomerRolePermission()
        {
            CustomerRolePermissionMappings = new HashSet<CustomerRolePermissionMapping>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CustomerRolePermissionMapping> CustomerRolePermissionMappings { get; set; }
    }
}
