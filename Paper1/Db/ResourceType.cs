using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class ResourceType
    {
        public ResourceType()
        {
            Resources = new HashSet<Resource>();
        }

        public int ResTypeId { get; set; }
        public string ResTypeName { get; set; } = null!;

        public virtual ICollection<Resource> Resources { get; set; }
    }
}
