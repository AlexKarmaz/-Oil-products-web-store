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
using System.Security.Principal;
using System.Threading;
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

namespace OilProducts.Filters
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            IPrincipal iPrincipal = Thread.CurrentPrincipal;
            bool b = iPrincipal.IsInRole("admin");
            if (!b)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary { 
                { "controller", "Home" }, { "action", "CheckAdmin" } 
            });
            }
        }
    }
}