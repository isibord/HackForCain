using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class Role
    {
        public Role()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}
