using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessConnect.DataStore.Model.Dbo
{
    public abstract class FileInfo
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string FileExtension { get; set; }

        public string Path { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public FileType FileTypeId { get; set; }

        public FileType Type { get; set; }
    }
}
