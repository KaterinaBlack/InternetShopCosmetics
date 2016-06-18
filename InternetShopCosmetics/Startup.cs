using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternetShopCosmetics.Startup))]
namespace InternetShopCosmetics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
