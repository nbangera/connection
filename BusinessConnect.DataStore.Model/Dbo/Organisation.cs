using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Organisation
    {
        public Organisation()
        {
            Brands = new HashSet<Brand>();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}
