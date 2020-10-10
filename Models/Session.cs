using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionTitle { get; set; }
        public int SeatCapacity { get; set; }
        // Not sure where, but start dates and times will likely need to be in here.
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
