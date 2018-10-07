using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class ProductFile :FileInfo
    {
     
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
