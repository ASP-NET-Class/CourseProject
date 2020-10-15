using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    // makes it so only Swimmers and Administrators have access to the Swimmer Controller 
    // and being able to make changes
    [Authorize(Roles= "Swimmer, Administrator")]
    public class SwimmerController : Controller
    {
        private readonly ApplicationDbContext db;
        public SwimmerController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
