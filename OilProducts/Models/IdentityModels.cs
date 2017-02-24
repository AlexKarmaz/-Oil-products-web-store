using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using System.Security.Claims;
using System.Threading.Tasks;
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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace OilProducts.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
     
    }

    public class ApplicationManager : UserManager<ApplicationUser>
    {
        public ApplicationManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }
        //public static ApplicationManager Create(IdentityFactoryOptions<ApplicationManager> options,
        //                                    IOwinContext context)
        //{
        //    ApplicationDbContext db = context.Get<ApplicationDbContext>();
        //    ApplicationManager manager = new ApplicationManager(new UserStore<ApplicationUser>(db));
        //    return manager;
        //}
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<OilProducts.Models.Orders> Orders { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.OrderDetails> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.Payments> Payments { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.DeliveryCompany> DeliveryCompanies { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.Products> Products { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.ShippingMethods> ShippingMethods { get; set; }

        public System.Data.Entity.DbSet<OilProducts.Models.BankPayments> BankPayments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}