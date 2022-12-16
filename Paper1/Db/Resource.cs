using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceAllocations = new HashSet<ResourceAllocation>();
        }

        public int ResId { get; set; }
        public string ResName { get; set; } = null!;
        public int ResTypeIdFk { get; set; }
        public int RemainingQuantity { get; set; }

        public virtual ResourceType ResTypeIdFkNavigation { get; set; } = null!;
        public virtual ICollection<ResourceAllocation> ResourceAllocations { get; set; }
    }
}
