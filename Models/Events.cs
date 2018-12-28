using System;
using System.Collections.Generic;

namespace PictureDatabase.Models
{
    public partial class Events
    {
        public Events()
        {
            Subscriptions = new HashSet<Subscriptions>();
        }

        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public Guid OrganizationId { get; set; }
        public string EventPhoto { get; set; }

        public Organizations Organization { get; set; }
        public ICollection<Subscriptions> Subscriptions { get; set; }
    }
}
