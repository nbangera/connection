using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class FileType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ProductFile> ProductFiles { get; set; }

        public virtual ICollection<AdvertisementFile> AdvertisementFiles { get; set; }
    }
}
