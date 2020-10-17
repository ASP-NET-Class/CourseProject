using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    // makes it so only Swimmers and Administrators have access to the Swimmer Controller 
    // and being able to make changes
    [Authorize(Roles = "Swimmer, Administrator")]

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
         public IActionResult AddProfile()
        {
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            Swimmer swimmer = new Swimmer();
            if (db.Swimmers.Any(i => i.UserId ==
                currentUserId))
                {
                swimmer = db.Swimmers.FirstOrDefault(i =>
                i.UserId == currentUserId);
                }
            else
            {
                swimmer.UserId = currentUserId;
            }
            return View(swimmer);
            
        }
        [HttpPost]
        public async Task<IActionResult> AddProfile
            (Swimmer swimmer)
        {
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            if(db.Swimmers.Any(i => i.UserId == currentUserId))
            {
                var swimmerToUpdate = db.Swimmers.FirstOrDefault
                    (i => i.UserId == currentUserId);
                swimmerToUpdate.SwimmerName = swimmer.SwimmerName;
                db.Update(swimmerToUpdate);
            }
            else
            {
                db.Add(swimmer);
            }
            await db.SaveChangesAsync();
            return View("Index");
        }
    }
}
