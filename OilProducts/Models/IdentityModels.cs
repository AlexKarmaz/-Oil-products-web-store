using Microsoft.AspNet.Identity.EntityFramework;

namespace OilProducts.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
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
    }
}