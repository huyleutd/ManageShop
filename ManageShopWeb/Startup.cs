using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageShopWeb.Startup))]
namespace ManageShopWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
