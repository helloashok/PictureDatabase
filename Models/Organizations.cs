using System;
using System.Collections.Generic;

namespace PictureDatabase.Models
{
    public partial class Organizations
    {
        public Organizations()
        {
            Events = new HashSet<Events>();
            Users = new HashSet<Users>();
        }

        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string LicensePath { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string PrimaryContactPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public ICollection<Events> Events { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
