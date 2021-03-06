﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Brand
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; } = true;

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public long OrganisationId { get; set; }
        public virtual Organisation Organisation { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
