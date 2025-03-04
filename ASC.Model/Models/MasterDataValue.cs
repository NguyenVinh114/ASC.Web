using ASC.Model.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC.Model.Models
{
    public class MasterDataValue : BaseEntity, IAuditTracker
    {
        public MasterDataValue() { }
       
        public MasterDataValue(string masterDataPartitionkey, string value)
        {
            this.PartitionKey = masterDataPartitionkey;
            this.RowKey = Guid.NewGuid().ToString();
        }
        
        public bool IsActive { get; set; }
        
        public string Name { get; set; }
    }

}
