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
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Data.Entity;
using OilProducts.Filters;
using System.Threading;
using System.Security.Principal;
using Calabonga.Xml.Exports;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace OilProducts.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        
        [CustomAuthAttribute]
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
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
           // var roleAdmin = new IdentityRole("admin");
            //roleManager.Create(roleAdmin);
            var result = userManager.FindById(User.Identity.GetUserId());

            if (password.Equals(AdminPassword)) 
            {
                userManager.AddToRole(User.Identity.GetUserId(), "admin");
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