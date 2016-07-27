using System;
using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class DonationPlatform
    {
        public DonationPlatform()
        {
            DonationActivity = new HashSet<DonationActivity>();
        }

        public int Id { get; set; }
        public string DonationPlatformName { get; set; }

        public virtual ICollection<DonationActivity> DonationActivity { get; set; }
    }
}
