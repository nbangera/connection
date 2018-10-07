using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; } = true;

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public long BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int ProductCategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }

        public virtual ProductFile File { get; set; }
    }
}
