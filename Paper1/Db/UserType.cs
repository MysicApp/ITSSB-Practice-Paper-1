using System;
using System.Collections.Generic;

namespace Paper1.Db
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
