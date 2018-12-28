using System;
using System.Collections.Generic;

namespace PictureDatabase.Models
{
    public partial class Subscriptions
    {
        public Guid SubscriptionId { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }

        public Events Event { get; set; }
        public Users User { get; set; }
    }
}
