using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonTitle { get; set; }
        public string SkillLevel { get; set; }
        public int Tuition { get; set; }
    }
}
