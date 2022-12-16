using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class Skill
    {
        public Skill()
        {
            ResourceAllocations = new HashSet<ResourceAllocation>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; } = null!;

        public virtual ICollection<ResourceAllocation> ResourceAllocations { get; set; }
    }
}
