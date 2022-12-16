using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class ResourceAllocation
    {
        public int AllocId { get; set; }
        public int ResIdFk { get; set; }
        public int SkillIdFk { get; set; }

        public virtual Resource ResIdFkNavigation { get; set; } = null!;
        public virtual Skill SkillIdFkNavigation { get; set; } = null!;
    }
}
