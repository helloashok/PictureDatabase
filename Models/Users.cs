using System;
using System.Collections.Generic;

namespace PictureDatabase.Models
{
    public partial class Users
    {
        public Users()
        {
            Subscriptions = new HashSet<Subscriptions>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public Guid? OrganizationId { get; set; }
        public DateTime? ResetTime { get; set; }

        public Organizations Organization { get; set; }
        public Users User { get; set; }
        public Users InverseUser { get; set; }
        public ICollection<Subscriptions> Subscriptions {
            get; set; }
    }
}
