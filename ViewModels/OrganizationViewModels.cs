using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureDatabase.ViewModels
{
    public class OrganizationViewModels
    {
      // public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string LicensePath { get; set; }
        public string LicenseExt { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string PrimaryContactPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
    }
}
