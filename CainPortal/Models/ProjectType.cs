using System;
using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string ProjectType1 { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
