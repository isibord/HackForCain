using System;
using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class DonationActivity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PeopleId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public int ProjectId { get; set; }
        public DateTime? AppreciationNotificationDate { get; set; }
        public int DonationPlatformId { get; set; }
        public DateTime? ReceiptSendDate { get; set; }
        public string Comment { get; set; }

        public virtual DonationPlatform DonationPlatform { get; set; }
    }
}
