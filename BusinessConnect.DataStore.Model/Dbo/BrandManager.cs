﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class BrandManager
    {
        public long Id { get; set; }

        public virtual Organisation Organisation { get; set; }

        public long OrganisationId { get; set; }

        public virtual Customer Customer { get; set; }

        public long CustomerId { get; set; }


    }
}
