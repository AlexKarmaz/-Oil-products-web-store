using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OilProducts.Models;
using System.Security;
using System.Web.Security;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace OilProducts.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<ActionResult> ShowUsers()
        {
            System.Collections.Generic.IList<ApplicationUser> users = await db.Users.ToListAsync();
            return View(users);
        }

        [Authorize]
        public ActionResult CheckAdmin()
        {
            
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CheckAdmin(string AdminPassword)
        {
            String password = "123456";
            if (password.Equals(AdminPassword))
            {
                Roles.AddUserToRole("User.Identity.GetUserId", "admin");
                return RedirectToAction("Index", "Home");
            }
            return PartialView("CheckAdminPartial");
        }

        public ActionResult Create()
        {
            return View("Orders","Create");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}