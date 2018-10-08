using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CustomerRolePermissionMapping
    {
        public int Id { get; set; }

        public CustomerRole CustomerRole { get; set; }
        public int CustomerRoleId { get; set; }

        public CustomerRolePermission Permission { get; set; }
        public int CustomerPermissionId { get; set; }


    }
}
