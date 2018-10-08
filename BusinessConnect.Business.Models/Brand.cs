using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.Domain.Model
{ 
    public class Brand
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long OrganisationId { get; set; }
        public virtual Organisation Organisation { get; set; }

    }
}
