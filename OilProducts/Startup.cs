using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OilProducts.Startup))]
namespace OilProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
