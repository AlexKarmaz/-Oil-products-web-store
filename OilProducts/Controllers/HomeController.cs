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

namespace OilProducts.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowUsers()
        {
            //MembershipUserCollection users = Membership.GetAllUsers();
            //var users = db.Users.ToList();
            System.Collections.Generic.IList<ApplicationUser> users = db.Users.ToList();
            return View(users);
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