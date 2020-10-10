using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    // this will likely be the session progress report information
    public enum LetterGrade
    {
        A, B, C, D, F, I, W, P
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int SwimmerId { get; set; }
        public int SessionId { get; set; }
        public Swimmer Swimmer { get; set; }
        public Session Session { get; set; }
        [DisplayFormat(NullDisplayText = "No Grade")]
        public LetterGrade? LetterGrade { get; set; }
    }
}
