using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public class CampaignApplicationStatus
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
