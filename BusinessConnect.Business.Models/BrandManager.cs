using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.Domain.Model
{
    public class BrandManager
    {
        public long Id { get; set; }

        public virtual Organisation Organisation { get; set; }

        public virtual User User { get; set; }


    }
}
