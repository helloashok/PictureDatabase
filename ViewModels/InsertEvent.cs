using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureDatabase.ViewModels
{
    public class InsertEvent
    {

        public string EventName { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string EventPhoto { get; set; }
        public string PhotoExtension { get; set; }
    }
}
