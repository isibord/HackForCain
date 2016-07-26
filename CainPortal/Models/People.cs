using System;
using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class People
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Company { get; set; }
        public int RoleId { get; set; }
        public DateTime DateOfFirstContact { get; set; }
        public string Comments { get; set; }

        public virtual Role Role { get; set; }
    }
}
