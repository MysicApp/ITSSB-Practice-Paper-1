using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class User
    {
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserPw { get; set; } = null!;
        public int UserTypeIdFk { get; set; }

        public virtual UserType UserTypeIdFkNavigation { get; set; } = null!;
    }
}
