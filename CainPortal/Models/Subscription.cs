
namespace CainPortal.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string SubscriptionInfo { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
