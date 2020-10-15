using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    // makes it so only Coaches and Administrators have access to the Coach Controller 
    // and being able to make changes
    [Authorize(Roles="Coach, Administrator")]
    public class CoachController : Controller
    {
        private readonly ApplicationDbContext db;
        public CoachController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
