using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.Domain.Model
{
    public class Organisation
    {
        public Organisation()
        {
            
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public List<Brand> Brands { get; set; }
    }
}
